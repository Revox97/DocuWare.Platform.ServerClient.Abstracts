using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FunctionExpressionQuery(SDK.FunctionExpressionQuery obj) : IFunctionExpressionQuery
    {
        internal SDK.FunctionExpressionQuery Obj { get; } = obj;

		public List<ISortedField> SortOrder
		{
			get => Obj.SortOrder.Select(x => new SortedField(x) as ISortedField).ToList();
			set => Obj.SortOrder = value.Select(x => ((SortedField)x).Obj).ToList();
		}

		public List<string> ResultFields
		{
			get => Obj.ResultFields;
			set => Obj.ResultFields = value;
		}

		public IFunctionExpression Expression
		{
			get => new FunctionExpression(Obj.Expression);
			set => Obj.Expression = ((FunctionExpression)value).Obj;
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
    }
}
