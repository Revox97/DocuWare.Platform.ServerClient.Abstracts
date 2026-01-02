using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ErrorProcessing(DocuWare.Services.Http.Client.ErrorProcessing obj) : ErrorProcessing
    {
        internal DocuWare.Services.Http.Client.ErrorProcessing Obj { get; } = obj;
    }
}
