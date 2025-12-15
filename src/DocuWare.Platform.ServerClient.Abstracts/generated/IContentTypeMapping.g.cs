using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IContentTypeMapping
    {
		IContentTypeMapping Default { get; }

		string GetContentTypeFromFileExtension(string fileExt);
    }
}
