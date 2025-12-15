using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FieldValueStatistics(SDK.FieldValueStatistics obj) : IFieldValueStatistics
    {
        internal SDK.FieldValueStatistics Obj { get; } = obj;

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
