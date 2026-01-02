using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SynchronizationSettings(SDK.SynchronizationSettings obj) : ISynchronizationSettings
    {
        internal SDK.SynchronizationSettings Obj { get; } = obj;

        public List<IFieldMapping> FieldMappings
        {
            get => Obj.FieldMappings.Select(x => new FieldMapping(x) as IFieldMapping).ToList();
            set => Obj.FieldMappings = value.Select(x => ((FieldMapping)x).Obj).ToList();
        }

        public DocuWare.Platform.ServerClient.SynchronizationOperation SynchronizationOperation
        {
            get => Obj.SynchronizationOperation;
            set => Obj.SynchronizationOperation = value;
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
