using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUserInfo
    {
		Link[] Links { get; set; }
		string ValidateRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		string PostToValidateRelationForString(IUserValidation dataToSend);
		Task<DeserializedHttpResponse<string>> PostToValidateRelationForStringAsync(IUserValidation dataToSend);
		Task<DeserializedHttpResponse<string>> PostToValidateRelationForStringAsync(CancellationToken cancellationToken, IUserValidation dataToSend);
    }
}
