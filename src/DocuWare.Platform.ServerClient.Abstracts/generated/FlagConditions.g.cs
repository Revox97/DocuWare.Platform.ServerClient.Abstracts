using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FlagConditions(SDK.FlagConditions obj) : IFlagConditions
    {
        internal SDK.FlagConditions Obj { get; } = obj;

        public bool IncludeCheckedOut
        {
            get => Obj.IncludeCheckedOut;
            set => Obj.IncludeCheckedOut = value;
        }

        public bool IncludeAppended
        {
            get => Obj.IncludeAppended;
            set => Obj.IncludeAppended = value;
        }
    }
}
