using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateProcessData(SDK.BatchUpdateProcessData obj) : IBatchUpdateProcessData
    {
        internal SDK.BatchUpdateProcessData Obj { get; } = obj;

        public List<IDocumentIndexField> Field
        {
            get => Obj.Field.Select(x => new DocumentIndexField(x) as IDocumentIndexField).ToList();
            set => Obj.Field = value.Select(x => ((DocumentIndexField)x).Obj).ToList();
        }

        public string StoreDialogId
        {
            get => Obj.StoreDialogId;
            set => Obj.StoreDialogId = value;
        }

        public int? BatchSize
        {
            get => Obj.BatchSize;
            set => Obj.BatchSize = value;
        }

        public bool BreakOnError
        {
            get => Obj.BreakOnError;
            set => Obj.BreakOnError = value;
        }

        public bool ForceUpdate
        {
            get => Obj.ForceUpdate;
            set => Obj.ForceUpdate = value;
        }
    }
}
