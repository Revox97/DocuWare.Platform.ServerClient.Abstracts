using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateProcessData(DocuWare.Platform.ServerClient.BatchUpdateProcessData obj) : IBatchUpdateProcessData
    {
        internal DocuWare.Platform.ServerClient.BatchUpdateProcessData Obj { get; } = obj;

        public List<IDocumentIndexField> Field
        {
            get => Obj.Field.Select(x => new DocumentIndexField(x) as IDocumentIndexField).ToList();
            set => Obj.Field = value.Select(x => ((DocumentIndexField)x).Obj).ToList();
        }

        public int? BatchSize
        {
            get => Obj.BatchSize;
            set => Obj.BatchSize = value;
        }

        public bool ForceUpdate
        {
            get => Obj.ForceUpdate;
            set => Obj.ForceUpdate = value;
        }
    }
}
