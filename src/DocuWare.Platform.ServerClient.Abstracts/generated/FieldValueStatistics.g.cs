using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FieldValueStatistics(DocuWare.Platform.ServerClient.FieldValueStatistics obj) : IFieldValueStatistics
    {
        internal DocuWare.Platform.ServerClient.FieldValueStatistics Obj { get; } = obj;

        public IDocumentIndexFieldValue Value
        {
            get => new DocumentIndexFieldValue(Obj.Value);
            set => Obj.Value = ((DocumentIndexFieldValue)value).Obj;
        }

        public long Count
        {
            get => Obj.Count;
            set => Obj.Count = value;
        }
    }
}
