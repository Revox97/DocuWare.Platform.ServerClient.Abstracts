using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IContentTypeMapping
    {

		string GetContentTypeFromFileExtension(string fileExt);
    }
}
