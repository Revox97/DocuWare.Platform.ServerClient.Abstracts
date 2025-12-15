using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ErrorHistoryStep(SDK.ErrorHistoryStep obj) : IErrorHistoryStep
    {
        internal SDK.ErrorHistoryStep Obj { get; } = obj;

        public string ErrorMessage
        {
            get => Obj.ErrorMessage;
            set => Obj.ErrorMessage = value;
        }

        public string FullErrorMessage
        {
            get => Obj.FullErrorMessage;
            set => Obj.FullErrorMessage = value;
        }

        public string OutputName
        {
            get => Obj.OutputName;
            set => Obj.OutputName = value;
        }
    }
}
