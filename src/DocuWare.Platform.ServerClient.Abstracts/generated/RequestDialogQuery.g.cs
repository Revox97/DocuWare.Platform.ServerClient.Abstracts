using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RequestDialogQuery(SDK.RequestDialogQuery obj) : IRequestDialogQuery
    {
        internal SDK.RequestDialogQuery Obj { get; } = obj;

        public List<DialogTypes> DialogTypes
        {
            get => Obj.DialogTypes.ConvertAll(o => (DialogTypes)o);
            set => Obj.DialogTypes = value.ConvertAll(v => (DocuWare.Platform.ServerClient.DialogTypes)v);
        }
    }
}
