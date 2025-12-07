using DocuWare.Platform.ServerClient.Abstracts.Generation.Contracts;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Services.Generation
{
    internal class InstanceGenerationService : IGenerationService
    {
        public void Generate(Type type)
        {
            new InterfaceGenerationService().Generate(type);
            new ImplementationGenerationService().Generate(type);
        }
    }
}
