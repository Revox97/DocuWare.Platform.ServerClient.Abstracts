using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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
