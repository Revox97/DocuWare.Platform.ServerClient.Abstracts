using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AdditionalOrganizationInfo(DocuWare.Platform.ServerClient.AdditionalOrganizationInfo obj) : IAdditionalOrganizationInfo
    {
        internal DocuWare.Platform.ServerClient.AdditionalOrganizationInfo Obj { get; } = obj;

        public List<string> CompanyNames
        {
            get => Obj.CompanyNames;
            set => Obj.CompanyNames = value;
        }

        public List<string> AddressLines
        {
            get => Obj.AddressLines;
            set => Obj.AddressLines = value;
        }

        public string Administrator
        {
            get => Obj.Administrator;
            set => Obj.Administrator = value;
        }

        public string EMail
        {
            get => Obj.EMail;
            set => Obj.EMail = value;
        }

        public string SystemNumber
        {
            get => Obj.SystemNumber;
            set => Obj.SystemNumber = value;
        }

        public string RuntimeVersion
        {
            get => Obj.RuntimeVersion;
            set => Obj.RuntimeVersion = value;
        }

        public string OrganizationType
        {
            get => Obj.OrganizationType;
            set => Obj.OrganizationType = value;
        }
    }
}
