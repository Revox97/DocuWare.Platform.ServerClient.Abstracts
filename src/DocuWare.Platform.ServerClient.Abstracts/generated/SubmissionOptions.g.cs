using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SubmissionOptions(DocuWare.Platform.ServerClient.SubmissionOptions obj) : ISubmissionOptions
    {
        internal DocuWare.Platform.ServerClient.SubmissionOptions Obj { get; } = obj;
    }
}
