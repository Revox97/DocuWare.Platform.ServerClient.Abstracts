using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SynchronizationSettings(SDK.SynchronizationSettings obj) : ISynchronizationSettings
    {
        internal SDK.SynchronizationSettings Obj { get; } = obj;

        public string MediaType => Obj.MediaType;

        public List<IFieldMapping> FieldMappings
        {
            get => Obj.FieldMappings.Select(x => new FieldMapping(x) as IFieldMapping).ToList();
            set => Obj.FieldMappings = value.Select(x => ((FieldMapping)x).Obj).ToList();
        }

        public SynchronizationOperation SynchronizationOperation
        {
            get => (SynchronizationOperation)Obj.SynchronizationOperation;
            set => Obj.SynchronizationOperation = (DocuWare.Platform.ServerClient.SynchronizationOperation)value;
        }

        public int Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public bool PreserveSystemFields
        {
            get => Obj.PreserveSystemFields;
            set => Obj.PreserveSystemFields = value;
        }

        public bool ImportNotMappedFields
        {
            get => Obj.ImportNotMappedFields;
            set => Obj.ImportNotMappedFields = value;
        }

        public bool SynchronizeFiles
        {
            get => Obj.SynchronizeFiles;
            set => Obj.SynchronizeFiles = value;
        }
    }
}
