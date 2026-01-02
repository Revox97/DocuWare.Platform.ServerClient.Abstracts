using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class NewUser(DocuWare.Platform.ServerClient.NewUser obj) : INewUser
    {
        internal DocuWare.Platform.ServerClient.NewUser Obj { get; } = obj;

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public string DbName
        {
            get => Obj.DbName;
            set => Obj.DbName = value;
        }

        public string Email
        {
            get => Obj.Email;
            set => Obj.Email = value;
        }

        public string NetworkId
        {
            get => Obj.NetworkId;
            set => Obj.NetworkId = value;
        }

        public string Password
        {
            get => Obj.Password;
            set => Obj.Password = value;
        }

        public string ExternalId
        {
            get => Obj.ExternalId;
            set => Obj.ExternalId = value;
        }

        public string ExternalProvider
        {
            get => Obj.ExternalProvider;
            set => Obj.ExternalProvider = value;
        }
    }
}
