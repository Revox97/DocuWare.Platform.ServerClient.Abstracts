using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DialogPropertiesResultList(SDK.DialogPropertiesResultList obj) : IDialogPropertiesResultList
    {
        internal SDK.DialogPropertiesResultList Obj { get; } = obj;

        public List<IResultDialogFunction> Functions
        {
            get => Obj.Functions.Select(x => new ResultDialogFunction(x) as IResultDialogFunction).ToList();
            set => Obj.Functions = value.Select(x => ((ResultDialogFunction)x).Obj).ToList();
        }

        public IViewerDialog ViewerDialog
        {
            get => new ViewerDialog(Obj.ViewerDialog);
            set => Obj.ViewerDialog = ((ViewerDialog)value).Obj;
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
