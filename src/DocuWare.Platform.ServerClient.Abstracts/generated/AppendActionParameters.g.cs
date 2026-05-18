using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AppendActionParameters(SDK.AppendActionParameters obj) : IAppendActionParameters
    {
        internal SDK.AppendActionParameters Obj { get; } = obj;

        public bool RemoveSourceDocuments
        {
            get => Obj.RemoveSourceDocuments;
            set => Obj.RemoveSourceDocuments = value;
        }

        public List<IAppendActionDocuments> DocumentsInFront
        {
            get => Obj.DocumentsInFront.Select(x => new AppendActionDocuments(x) as IAppendActionDocuments).ToList();
            set => Obj.DocumentsInFront = value.Select(x => ((AppendActionDocuments)x).Obj).ToList();
        }

        public List<IAppendActionDocuments> DocumentsAtBack
        {
            get => Obj.DocumentsAtBack.Select(x => new AppendActionDocuments(x) as IAppendActionDocuments).ToList();
            set => Obj.DocumentsAtBack = value.Select(x => ((AppendActionDocuments)x).Obj).ToList();
        }
    }
}
