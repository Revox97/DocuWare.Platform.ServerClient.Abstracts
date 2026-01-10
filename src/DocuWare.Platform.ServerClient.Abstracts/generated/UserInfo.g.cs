using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class UserInfo(DocuWare.Platform.ServerClient.UserInfo obj) : IUserInfo
    {
        internal DocuWare.Platform.ServerClient.UserInfo Obj { get; } = obj;

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

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

		public string PostToValidateRelationForString(IUserValidation dataToSend) => Obj.PostToValidateRelationForString(((UserValidation)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PostToValidateRelationForStringAsync(IUserValidation dataToSend) => await Obj.PostToValidateRelationForStringAsync(((UserValidation)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PostToValidateRelationForStringAsync(CancellationToken cancellationToken, IUserValidation dataToSend) => await Obj.PostToValidateRelationForStringAsync(cancellationToken, ((UserValidation)dataToSend).Obj);
    }
}
