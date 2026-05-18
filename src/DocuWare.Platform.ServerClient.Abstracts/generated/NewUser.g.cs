using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class NewUser(SDK.NewUser obj) : INewUser
    {
        internal SDK.NewUser Obj { get; } = obj;

        public IRegionalSettings RegionalSettings
        {
            get => new RegionalSettings(Obj.RegionalSettings);
            set => Obj.RegionalSettings = ((RegionalSettings)value).Obj;
        }

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

        public string ExternalIdpUserId
        {
            get => Obj.ExternalIdpUserId;
            set => Obj.ExternalIdpUserId = value;
        }

        public string ExternalIdp
        {
            get => Obj.ExternalIdp;
            set => Obj.ExternalIdp = value;
        }

        public string FirstName
        {
            get => Obj.FirstName;
            set => Obj.FirstName = value;
        }

        public string LastName
        {
            get => Obj.LastName;
            set => Obj.LastName = value;
        }

        public bool SkipCreatingDocumentTray
        {
            get => Obj.SkipCreatingDocumentTray;
            set => Obj.SkipCreatingDocumentTray = value;
        }
    }
}
