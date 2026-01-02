using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SubmissionOptions(SDK.SubmissionOptions obj) : ISubmissionOptions
    {
        internal SDK.SubmissionOptions Obj { get; } = obj;
    }
}
