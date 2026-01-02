using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExtendedConfigurationRights(DocuWare.Platform.ServerClient.ExtendedConfigurationRights obj) : IExtendedConfigurationRights
    {
        internal DocuWare.Platform.ServerClient.ExtendedConfigurationRights Obj { get; } = obj;

        public bool Forms
        {
            get => Obj.Forms;
            set => Obj.Forms = value;
        }
    }
}
