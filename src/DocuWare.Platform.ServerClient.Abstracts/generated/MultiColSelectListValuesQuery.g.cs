using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MultiColSelectListValuesQuery(DocuWare.Platform.ServerClient.MultiColSelectListValuesQuery obj) : IMultiColSelectListValuesQuery
    {
        internal DocuWare.Platform.ServerClient.MultiColSelectListValuesQuery Obj { get; } = obj;

        public List<IMultiColSelectListExpressionCondition> Condition
        {
            get => Obj.Condition.Select(x => new MultiColSelectListExpressionCondition(x) as IMultiColSelectListExpressionCondition).ToList();
            set => Obj.Condition = value.Select(x => ((MultiColSelectListExpressionCondition)x).Obj).ToList();
        }

        public string StartsWithColumn
        {
            get => Obj.StartsWithColumn;
            set => Obj.StartsWithColumn = value;
        }

        public string StartsWithValue
        {
            get => Obj.StartsWithValue;
            set => Obj.StartsWithValue = value;
        }

        public int Start
        {
            get => Obj.Start;
            set => Obj.Start = value;
        }

        public int Count
        {
            get => Obj.Count;
            set => Obj.Count = value;
        }

        public DocuWare.Platform.ServerClient.DialogExpressionOperation Operation
        {
            get => Obj.Operation;
            set => Obj.Operation = value;
        }
    }
}
