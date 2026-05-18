using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUsersByRole
    {
		List<IUser> User { get; set; }
		string RoleId { get; set; }
		bool IncludeGroupUsers { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
