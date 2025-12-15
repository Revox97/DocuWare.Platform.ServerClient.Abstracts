using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Notifications(SDK.Notifications obj) : INotifications
    {
        internal SDK.Notifications Obj { get; } = obj;

        public List<INotification> Notification
        {
            get => Obj.Notification.Select(x => new Notification(x) as INotification).ToList();
            set => Obj.Notification = value.Select(x => ((Notification)x).Obj).ToList();
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public int Timeout
        {
            get => Obj.Timeout;
            set => Obj.Timeout = value;
        }

        public string SelfRelationLink => Obj.SelfRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public INotifications GetNotificationsFromSelfRelation() => new Notifications(Obj.GetNotificationsFromSelfRelation());

        public async Task<DeserializedHttpResponse<INotifications>> GetNotificationsFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.INotifications result = await Obj.GetNotificationsFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new INotifications(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<INotifications>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<INotifications>> GetNotificationsFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.INotifications result = await Obj.GetNotificationsFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new INotifications(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<INotifications>(temp).ConfigureAwait(false);
        }
    }
}
