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
            string namespaceName = type.Namespace ?? string.Empty;
            string? namespaceExtension = null;

            if (!namespaceName.StartsWith("DocuWare.Platform.ServerClient"))
            {
                string[] namespaceValues = namespaceName.Split('.');
                int indexServerClient = Array.FindIndex(namespaceValues, x => x.Equals("DocuWare", StringComparison.OrdinalIgnoreCase));

                namespaceExtension = string.Join('.', namespaceValues[(indexServerClient + 1)..]);
            }
            else if (!namespaceName.EndsWith("ServerClient"))
            {
                string[] namespaceValues = namespaceName.Split('.');
                int indexServerClient = Array.FindIndex(namespaceValues, x => x.Equals("ServerClient", StringComparison.OrdinalIgnoreCase));

                namespaceExtension = string.Join('.', namespaceValues[(indexServerClient + 1)..]);
            }

            if (hasBaseType)
            {
                if (type.BaseType!.IsAbstract)
                    new InterfaceGenerationService(namespaceExtension).Generate(type.BaseType!);

                new InheritedInterfaceGenerationService(namespaceExtension).Generate(type);
            }
            else
            {
                new InterfaceGenerationService(namespaceExtension).Generate(type);
            }

            if (!type.IsAbstract && !type.Name.EndsWith("Extensions"))
                new ImplementationGenerationService(namespaceExtension).Generate(type);
        }
    }
}
