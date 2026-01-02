using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DialogPropertiesTaskList(SDK.DialogPropertiesTaskList obj) : IDialogPropertiesTaskList
    {
        internal SDK.DialogPropertiesTaskList Obj { get; } = obj;

        public string ConditionString
        {
            get => Obj.ConditionString;
            set => Obj.ConditionString = value;
        }

        public bool Private
        {
            get => Obj.Private;
            set => Obj.Private = value;
        }

        public bool AutoRefresh
        {
            get => Obj.AutoRefresh;
            set => Obj.AutoRefresh = value;
        }

        public int AutoRefreshPeriod
        {
            get => Obj.AutoRefreshPeriod;
            set => Obj.AutoRefreshPeriod = value;
        }

        public List<IResultDialogFunction> Functions
        {
            get => Obj.Functions.Select(x => new ResultDialogFunction(x) as IResultDialogFunction).ToList();
            set => Obj.Functions = value.Select(x => ((ResultDialogFunction)x).Obj).ToList();
        }

        public List<ISortedField> SortOrder
        {
            get => Obj.SortOrder.Select(x => new SortedField(x) as ISortedField).ToList();
            set => Obj.SortOrder = value.Select(x => ((SortedField)x).Obj).ToList();
        }

        public DocuWare.Platform.ServerClient.LetterCase DefaultListTextLetterCase
        {
            get => Obj.DefaultListTextLetterCase;
            set => Obj.DefaultListTextLetterCase = value;
        }

        public bool DisplayFirstDocument
        {
            get => Obj.DisplayFirstDocument;
            set => Obj.DisplayFirstDocument = value;
        }

        public bool ShowCheckedOutDocumens
        {
            get => Obj.ShowCheckedOutDocumens;
            set => Obj.ShowCheckedOutDocumens = value;
        }
    }
}
