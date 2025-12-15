using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentLinkExpressionQuery(SDK.DocumentLinkExpressionQuery obj) : IDocumentLinkExpressionQuery
    {
        internal SDK.DocumentLinkExpressionQuery Obj { get; } = obj;

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

		public List<IDialogExpressionCondition> Condition
		{
			get => Obj.Condition.Select(x => new DialogExpressionCondition(x) as IDialogExpressionCondition).ToList();
			set => Obj.Condition = value.Select(x => ((DialogExpressionCondition)x).Obj).ToList();
		}

		public DialogExpressionOperation Operation
		{
			get => new ialogExpressionOperation(Obj.Operation);
			set => Obj.Operation = ((ialogExpressionOperation)value).Obj;
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

		public bool CalculateTotalCount
		{
			get => Obj.CalculateTotalCount;
			set => Obj.CalculateTotalCount = value;
		}

		public bool WithoutLinks
		{
			get => Obj.WithoutLinks;
			set => Obj.WithoutLinks = value;
		}
    }
}
