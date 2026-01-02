using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TrashBinExpression(DocuWare.Platform.ServerClient.TrashBinExpression obj) : ITrashBinExpression
    {
        internal DocuWare.Platform.ServerClient.TrashBinExpression Obj { get; } = obj;

        public List<ITrashBinCondition> Condition
        {
            get => Obj.Condition.Select(x => new TrashBinCondition(x) as ITrashBinCondition).ToList();
            set => Obj.Condition = value.Select(x => ((TrashBinCondition)x).Obj).ToList();
        }

        public DocuWare.Platform.ServerClient.TrashBinExpressionOperation Operation
        {
            get => Obj.Operation;
            set => Obj.Operation = value;
        }
    }
}
