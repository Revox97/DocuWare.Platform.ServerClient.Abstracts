using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MultiColumnSelectListValuesQuery(SDK.MultiColumnSelectListValuesQuery obj) : IMultiColumnSelectListValuesQuery
    {
        internal SDK.MultiColumnSelectListValuesQuery Obj { get; } = obj;

        public List<IMultiColumnSelectListExpressionCondition> Condition
        {
            get => Obj.Condition.Select(x => new MultiColumnSelectListExpressionCondition(x) as IMultiColumnSelectListExpressionCondition).ToList();
            set => Obj.Condition = value.Select(x => ((MultiColumnSelectListExpressionCondition)x).Obj).ToList();
        }

        public DocuWare.Platform.ServerClient.DialogExpressionOperation Operation
        {
            get => Obj.Operation;
            set => Obj.Operation = value;
        }

        public string SourceColumn
        {
            get => Obj.SourceColumn;
            set => Obj.SourceColumn = value;
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

        public string ValuePrefix
        {
            get => Obj.ValuePrefix;
            set => Obj.ValuePrefix = value;
        }

        public string ReturnType
        {
            get => Obj.ReturnType;
            set => Obj.ReturnType = value;
        }
    }
}
