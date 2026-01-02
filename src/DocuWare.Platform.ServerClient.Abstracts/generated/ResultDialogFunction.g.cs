using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ResultDialogFunction(DocuWare.Platform.ServerClient.ResultDialogFunction obj) : IResultDialogFunction
    {
        internal DocuWare.Platform.ServerClient.ResultDialogFunction Obj { get; } = obj;

        public ResultDialogFunctionType Type
        {
            get => (ResultDialogFunctionType)Obj.Type;
            set => Obj.Type = (DocuWare.Platform.ServerClient.ResultDialogFunctionType)value;
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
