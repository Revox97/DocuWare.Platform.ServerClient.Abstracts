using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ResultDialogFunction(SDK.ResultDialogFunction obj) : IResultDialogFunction
    {
        internal SDK.ResultDialogFunction Obj { get; } = obj;

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
