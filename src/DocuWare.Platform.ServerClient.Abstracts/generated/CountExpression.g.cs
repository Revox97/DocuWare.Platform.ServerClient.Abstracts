using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CountExpression(DocuWare.Platform.ServerClient.CountExpression obj) : ICountExpression
    {
        internal DocuWare.Platform.ServerClient.CountExpression Obj { get; } = obj;

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
