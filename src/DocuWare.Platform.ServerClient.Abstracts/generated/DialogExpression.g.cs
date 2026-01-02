using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DialogExpression(DocuWare.Platform.ServerClient.DialogExpression obj) : IDialogExpression
    {
        internal DocuWare.Platform.ServerClient.DialogExpression Obj { get; } = obj;

        public List<IDialogExpressionCondition> Condition
        {
            get => Obj.Condition.Select(x => new DialogExpressionCondition(x) as IDialogExpressionCondition).ToList();
            set => Obj.Condition = value.Select(x => ((DialogExpressionCondition)x).Obj).ToList();
        }

        public List<string> AdditionalCabinets
        {
            get => Obj.AdditionalCabinets;
            set => Obj.AdditionalCabinets = value;
        }

        public string CompleteCondition
        {
            get => Obj.CompleteCondition;
            set => Obj.CompleteCondition = value;
        }

        public DialogExpressionOperation Operation
        {
            get => (DialogExpressionOperation)Obj.Operation;
            set => Obj.Operation = (DocuWare.Platform.ServerClient.DialogExpressionOperation)value;
        }

        public bool CompleteConditionInInvariantCulture
        {
            get => Obj.CompleteConditionInInvariantCulture;
            set => Obj.CompleteConditionInInvariantCulture = value;
        }

        public List<ISortedField> SortOrder
        {
            get => Obj.SortOrder.Select(x => new SortedField(x) as ISortedField).ToList();
            set => Obj.SortOrder = value.Select(x => ((SortedField)x).Obj).ToList();
        }

        public List<string> AdditionalResultFields
        {
            get => Obj.AdditionalResultFields;
            set => Obj.AdditionalResultFields = value;
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

        public bool ExcludeDefaultSystemFields
        {
            get => Obj.ExcludeDefaultSystemFields;
            set => Obj.ExcludeDefaultSystemFields = value;
        }

        public bool WithoutLinks
        {
            get => Obj.WithoutLinks;
            set => Obj.WithoutLinks = value;
        }

        public bool IncludeSuggestions
        {
            get => Obj.IncludeSuggestions;
            set => Obj.IncludeSuggestions = value;
        }

        public bool CalculateTotalCount
        {
            get => Obj.CalculateTotalCount;
            set => Obj.CalculateTotalCount = value;
        }
    }
}
