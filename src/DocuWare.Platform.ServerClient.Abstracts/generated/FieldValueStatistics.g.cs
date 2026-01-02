using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FieldValueStatistics(DocuWare.Platform.ServerClient.FieldValueStatistics obj) : IFieldValueStatistics
    {
        internal DocuWare.Platform.ServerClient.FieldValueStatistics Obj { get; } = obj;

        public long Count
        {
            get => Obj.Count;
            set => Obj.Count = value;
        }
    }
}
