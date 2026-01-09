using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IClientThrottleException: Exception
    {
		System.Collections.IDictionary Data { get; }
    }
}
