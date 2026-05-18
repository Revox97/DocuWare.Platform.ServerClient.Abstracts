using DocuWare.Platform.ServerClient.Abstracts.Generation.Contracts;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Extensions;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Wrapper;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Services.Generation
{
    internal class InstanceGenerationService : IGenerationService
    {
        public void Generate(Type type)
        {
            bool hasBaseType = type.BaseType is not null && type.BaseType.GetTypeDefinition().Category is TypeCategory.DocuWare or TypeCategory.Interface;

            if (hasBaseType)
            {
                if (type.BaseType!.IsAbstract)
                    new InterfaceGenerationService().Generate(type.BaseType!);

                new InheritedInterfaceGenerationService().Generate(type);
            }
            else
            {
                new InterfaceGenerationService().Generate(type);
            }

            if (!type.IsAbstract && !type.Name.EndsWith("Extensions"))
                new ImplementationGenerationService().Generate(type);
        }
    }
}
