using System.Reflection;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Wrapper;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Services.PropertyStrategies
{
    internal enum PropertyGenerationType
    {
        Get,
        GetSet
    }

    // Todo Make find strategy more compact - Lots of redundancy atm
    internal abstract class PropertyGenerationStrategy(PropertyGenerationType generationType)
    {
        private static bool s_isAbstract;
        private static bool s_isAsync;
        private static bool s_isArray;
        private static bool s_isList;
        private static bool s_isDwEnumList;
        private static bool s_isDocuWareType;
        private static bool s_hasSetter;
        private static bool s_isDoubleNestedDocuWareType;
        private static bool s_isDocuWareEnum;

        internal PropertyGenerationType GenerationType { get; init; } = generationType;

        internal virtual string Generate(PropertyInfo property, string returnTypeName, string name)
        {
            return GenerationType switch
            {
                PropertyGenerationType.Get => GenerateGet(property, returnTypeName, name),
                PropertyGenerationType.GetSet or _ => GenerateGetSet(property, returnTypeName, name),
            };
        }

        protected abstract string GenerateGet(PropertyInfo property, string returnTypeName, string name);
        protected abstract string GenerateGetSet(PropertyInfo property, string returnTypeName, string name);

        internal static PropertyGenerationStrategy FindStrategy(PropertyInfo property, TypeDef typeDefinition)
        {
            Type? type = property.PropertyType;

            if (type.Name.StartsWith("List"))
                type = type.GenericTypeArguments[0];

            s_isAbstract = type is not null && type.IsAbstract;
            s_isAsync = typeDefinition.Category is TypeCategory.Generic && typeDefinition.Name.StartsWith("Task<");
            s_isArray = (s_isAsync && typeDefinition.NestedType is not null && typeDefinition.NestedType.Name.EndsWith("[]")) || typeDefinition.Name.EndsWith("[]");
            s_isList = typeDefinition.Category is TypeCategory.List;
            s_isDwEnumList = s_isList && typeDefinition.NestedType!.Category is TypeCategory.Enum && typeDefinition.NestedType.FullName.StartsWith("DocuWare.Platform.ServerClient");
            s_isDocuWareType = IsDocuWareType(typeDefinition);
            s_hasSetter = property.GetSetMethod() is not null;
            s_isDoubleNestedDocuWareType = typeDefinition.Category is TypeCategory.List && typeDefinition.NestedType!.Category is TypeCategory.List && typeDefinition.NestedType!.NestedType!.Category is TypeCategory.DocuWare;
            s_isDocuWareEnum = typeDefinition.Category is TypeCategory.Enum && typeDefinition.FullName.StartsWith("DocuWare.Platform");

            return s_isAbstract
                ? FindAbstractPropertyStrategy()
                : FindNormalPropertyStrategy();
        }

        private static PropertyGenerationStrategy FindAbstractPropertyStrategy()
        {
            if (s_isDocuWareType)
            {
                if (s_hasSetter)
                {
                    if (s_isDwEnumList)
                        return new DocuWareEnumListPropertyGenerationStrategy(PropertyGenerationType.GetSet);

                    if (s_isArray)
                    {
                        // TODO: Why is this only handling a getter?
                        return s_isAsync
                            ? new AsyncDocuWareArrayPropertyGenerationStrategy(PropertyGenerationType.Get)
                            : new DocuWareArrayPropertyGenerationStrategy(PropertyGenerationType.Get);
                    }

                    return s_isList
                        ? new AbstractDocuWareListPropertyGenerationStrategy(PropertyGenerationType.GetSet)
                        : new AbstractDocuWarePropertyGenerationStrategy(PropertyGenerationType.GetSet);
                }

                if (s_isDwEnumList)
                    return new DocuWareEnumListPropertyGenerationStrategy(PropertyGenerationType.Get);

                if (s_isList)
                    return new AbstractDocuWareListPropertyGenerationStrategy(PropertyGenerationType.Get);

                if (s_isArray)
                {
                    return s_isAsync
                        ? new AsyncDocuWareArrayPropertyGenerationStrategy(PropertyGenerationType.Get)
                        : new DocuWareArrayPropertyGenerationStrategy(PropertyGenerationType.Get);
                }

                return new DocuWarePropertyGenerationStrategy(PropertyGenerationType.Get);
            }

            if (s_isDoubleNestedDocuWareType)
                return new DoubleNestedDocuWareListPropertyGenerationStrategy(PropertyGenerationType.GetSet);

            if (s_isDocuWareEnum)
            {
                PropertyGenerationType generationType = s_hasSetter ? PropertyGenerationType.GetSet : PropertyGenerationType.Get;
                return new DocuWareEnumPropertyGenerationStrategy(generationType);
            }

            if (s_hasSetter)
            {
                return s_isDwEnumList
                    ? new DocuWareEnumListPropertyGenerationStrategy(PropertyGenerationType.GetSet)
                    : new DefaultPropertyGenerationStrategy(PropertyGenerationType.GetSet);
            }

            return s_isDwEnumList
                ? new DocuWareEnumListPropertyGenerationStrategy(PropertyGenerationType.Get)
                : new DefaultPropertyGenerationStrategy(PropertyGenerationType.Get);
        }

        private static PropertyGenerationStrategy FindNormalPropertyStrategy()
        {
            return s_isDocuWareType
                ? FindDocuWarePropertyStrategy()
                : FindPropertyStrategy();
        }

        private static PropertyGenerationStrategy FindDocuWarePropertyStrategy()
        {
            if (s_hasSetter)
            {
                if (s_isDwEnumList)
                    return new DocuWareEnumListPropertyGenerationStrategy(PropertyGenerationType.GetSet);

                if (s_isArray)
                {
                    // TODO: Why is this only handling a getter?
                    return s_isAsync
                        ? new AsyncDocuWareArrayPropertyGenerationStrategy(PropertyGenerationType.Get)
                        : new DocuWareArrayPropertyGenerationStrategy(PropertyGenerationType.Get);
                }

                if (s_isList)
                    return new DocuWareListPropertyGenerationStrategy(PropertyGenerationType.GetSet);

                return new DocuWarePropertyGenerationStrategy(PropertyGenerationType.GetSet);
            }

            if (s_isDwEnumList)
                return new DocuWareEnumListPropertyGenerationStrategy(PropertyGenerationType.Get);

            if (s_isList)
                return new DocuWareListPropertyGenerationStrategy(PropertyGenerationType.Get);

            if (s_isArray)
            {
                return s_isAsync
                    ? new AsyncDocuWareArrayPropertyGenerationStrategy(PropertyGenerationType.Get)
                    : new DocuWareArrayPropertyGenerationStrategy(PropertyGenerationType.Get);
            }

            return new DocuWarePropertyGenerationStrategy(PropertyGenerationType.Get);
        }

        private static PropertyGenerationStrategy FindPropertyStrategy()
        {
            if (s_isDoubleNestedDocuWareType)
                return new DoubleNestedDocuWareListPropertyGenerationStrategy(PropertyGenerationType.GetSet);

            if (s_isDocuWareEnum)
            {
                PropertyGenerationType generationType = s_hasSetter ? PropertyGenerationType.GetSet : PropertyGenerationType.Get;
                return new DocuWareEnumPropertyGenerationStrategy(generationType);
            }

            if (s_hasSetter)
            {
                return s_isDwEnumList
                    ? new DocuWareEnumListPropertyGenerationStrategy(PropertyGenerationType.GetSet)
                    : new DefaultPropertyGenerationStrategy(PropertyGenerationType.GetSet);
            }

            return s_isDwEnumList
                ? new DocuWareEnumListPropertyGenerationStrategy(PropertyGenerationType.Get)
                : new DefaultPropertyGenerationStrategy(PropertyGenerationType.Get);
        }

        private static bool IsDocuWareType(TypeDef typeDefinition)
        {
            bool isDocuWareList = s_isList && typeDefinition.NestedType is not null && typeDefinition.NestedType.Category is TypeCategory.DocuWare;
            bool isDocuWareArray = s_isArray && (typeDefinition.NestedType is not null && typeDefinition.NestedType.Category is TypeCategory.DocuWare || typeDefinition.Category is TypeCategory.DocuWare);
            bool isDocuWare = typeDefinition.Category is TypeCategory.DocuWare;
            return isDocuWareList || isDocuWareArray || isDocuWare;
        }
    }
}
