using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MultiColSelectListExpressionCondition(SDK.MultiColSelectListExpressionCondition obj) : IMultiColSelectListExpressionCondition
    {
        internal SDK.MultiColSelectListExpressionCondition Obj { get; } = obj;

        public string Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }

        public string ColumnName
        {
            get => Obj.ColumnName;
            set => Obj.ColumnName = value;
        }

        public string Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }
    }
}
