using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class UserInfo(SDK.UserInfo obj) : IUserInfo
    {
        internal SDK.UserInfo Obj { get; } = obj;

        public IUser User
        {
            get => new User(Obj.User);
            set => Obj.User = ((User)value).Obj;
        }

        public ILoginInfo LoginInfo
        {
            get => new LoginInfo(Obj.LoginInfo);
            set => Obj.LoginInfo = ((LoginInfo)value).Obj;
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string ValidateRelationLink => Obj.ValidateRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

		public async string PostToValidateRelationForString(IUserValidation dataToSend) => Obj.PostToValidateRelationForString(dataToSend);

        public async Task<DeserializedHttpResponse<string>> PostToValidateRelationForStringAsync(IUserValidation dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PostToValidateRelationForStringAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> PostToValidateRelationForStringAsync(CancellationToken cancellationToken, IUserValidation dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PostToValidateRelationForStringAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }
    }
}
