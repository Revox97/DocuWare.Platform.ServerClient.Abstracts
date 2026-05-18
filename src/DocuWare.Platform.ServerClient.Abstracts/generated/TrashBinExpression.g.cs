using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TrashBinExpression(SDK.TrashBinExpression obj) : ITrashBinExpression
    {
        internal SDK.TrashBinExpression Obj { get; } = obj;

        public List<ITrashBinCondition> Condition
        {
            get => Obj.Condition.Select(x => new TrashBinCondition(x) as ITrashBinCondition).ToList();
            set => Obj.Condition = value.Select(x => ((TrashBinCondition)x).Obj).ToList();
        }

        public TrashBinExpressionOperation Operation
        {
            get => (TrashBinExpressionOperation)Obj.Operation;
            set => Obj.Operation = (DocuWare.Platform.ServerClient.TrashBinExpressionOperation)value;
        }
    }
}
