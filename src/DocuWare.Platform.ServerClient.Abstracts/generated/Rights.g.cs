using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Rights(SDK.Rights obj) : IRights
    {
        internal SDK.Rights Obj { get; } = obj;

        public List<Right> Right
        {
            get => Obj.Right.ConvertAll(o => (Right)o);
            set => Obj.Right = value.ConvertAll(v => (DocuWare.Platform.ServerClient.Right)v);
        }
    }
}
