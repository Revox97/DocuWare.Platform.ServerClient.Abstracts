using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FieldMappings(SDK.FieldMappings obj) : IFieldMappings
    {
        internal SDK.FieldMappings Obj { get; } = obj;

        public List<IFieldMapping> Mapping
        {
            get => Obj.Mapping.Select(x => new FieldMapping(x) as IFieldMapping).ToList();
            set => Obj.Mapping = value.Select(x => ((FieldMapping)x).Obj).ToList();
        }
    }
}
