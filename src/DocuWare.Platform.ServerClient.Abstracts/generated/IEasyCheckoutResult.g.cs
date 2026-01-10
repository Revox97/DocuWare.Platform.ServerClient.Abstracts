using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IEasyCheckoutResult
    {
		string EncodedFileName { get; }
		DeserializedHttpResponse<Stream> Response { get; }

		void Dispose();
    }
}
