using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ImportSettings(SDK.ImportSettings obj) : IImportSettings
    {
        internal SDK.ImportSettings Obj { get; } = obj;

        public string MediaType => Obj.MediaType;

        public List<IFieldMapping> FieldMappings
        {
            get => Obj.FieldMappings.Select(x => new FieldMapping(x) as IFieldMapping).ToList();
            set => Obj.FieldMappings = value.Select(x => ((FieldMapping)x).Obj).ToList();
        }

        public bool PreserveSystemFields
        {
            get => Obj.PreserveSystemFields;
            set => Obj.PreserveSystemFields = value;
        }
    }
}
