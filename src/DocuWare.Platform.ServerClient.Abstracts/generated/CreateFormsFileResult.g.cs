using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CreateFormsFileResult(SDK.CreateFormsFileResult obj) : ICreateFormsFileResult
    {
        internal SDK.CreateFormsFileResult Obj { get; } = obj;

        public string FilePath
        {
            get => Obj.FilePath;
            set => Obj.FilePath = value;
        }

        public string ContentType
        {
            get => Obj.ContentType;
            set => Obj.ContentType = value;
        }
    }
}
