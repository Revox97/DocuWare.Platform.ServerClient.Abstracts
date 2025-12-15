using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICreateFormsFileResult
    {
		string FilePath { get; set; }
		string ContentType { get; set; }
    }
}
