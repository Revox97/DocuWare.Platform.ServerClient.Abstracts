using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface INotifications
    {
		List<INotification> Notification { get; set; }
		Link[] Links { get; set; }
		int Timeout { get; set; }

		void SetProxy(HttpClientProxy proxy);
		INotifications GetNotificationsFromSelfRelation();
		Task<DeserializedHttpResponse<INotifications>> GetNotificationsFromSelfRelationAsync();
		Task<DeserializedHttpResponse<INotifications>> GetNotificationsFromSelfRelationAsync(CancellationToken cancellationToken);
    }
}
