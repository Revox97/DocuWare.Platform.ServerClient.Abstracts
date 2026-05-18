using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUserInfo
    {
		IUser User { get; set; }
		ILoginInfo LoginInfo { get; set; }
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		string PostToValidateRelationForString(IUserValidation dataToSend);
		Task<DeserializedHttpResponse<string>> PostToValidateRelationForStringAsync(IUserValidation dataToSend);
		Task<DeserializedHttpResponse<string>> PostToValidateRelationForStringAsync(CancellationToken cancellationToken, IUserValidation dataToSend);
    }
}
