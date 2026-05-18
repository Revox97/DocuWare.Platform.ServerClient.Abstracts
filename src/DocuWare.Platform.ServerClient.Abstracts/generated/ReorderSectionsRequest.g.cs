using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ReorderSectionsRequest(SDK.ReorderSectionsRequest obj) : IReorderSectionsRequest
    {
        internal SDK.ReorderSectionsRequest Obj { get; } = obj;

        public List<string> SectionId
        {
            get => Obj.SectionId;
            set => Obj.SectionId = value;
        }
    }
}
