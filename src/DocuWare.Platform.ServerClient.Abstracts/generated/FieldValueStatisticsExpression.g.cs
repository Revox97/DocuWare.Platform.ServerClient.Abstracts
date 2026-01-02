using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FieldValueStatisticsExpression(DocuWare.Platform.ServerClient.FieldValueStatisticsExpression obj) : IFieldValueStatisticsExpression
    {
        internal DocuWare.Platform.ServerClient.FieldValueStatisticsExpression Obj { get; } = obj;

        public string FieldName
        {
            get => Obj.FieldName;
            set => Obj.FieldName = value;
        }

        public int Limit
        {
            get => Obj.Limit;
            set => Obj.Limit = value;
        }
    }
}
