using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ResultDialogFunction(DocuWare.Platform.ServerClient.ResultDialogFunction obj) : IResultDialogFunction
    {
        internal DocuWare.Platform.ServerClient.ResultDialogFunction Obj { get; } = obj;

        public DocuWare.Platform.ServerClient.ResultDialogFunctionType Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }

        public bool InToolBar
        {
            get => Obj.InToolBar;
            set => Obj.InToolBar = value;
        }

        public bool AsButton
        {
            get => Obj.AsButton;
            set => Obj.AsButton = value;
        }
    }
}
