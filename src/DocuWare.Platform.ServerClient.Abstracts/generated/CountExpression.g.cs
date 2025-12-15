using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CountExpression(SDK.CountExpression obj) : ICountExpression
    {
        internal SDK.CountExpression Obj { get; } = obj;

        public IDialogExpression DialogExpression
        {
            get => new DialogExpression(Obj.DialogExpression);
            set => Obj.DialogExpression = ((DialogExpression)value).Obj;
        }

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
