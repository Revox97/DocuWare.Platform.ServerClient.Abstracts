using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ConfigurationRights(DocuWare.Platform.ServerClient.ConfigurationRights obj) : IConfigurationRights
    {
        internal DocuWare.Platform.ServerClient.ConfigurationRights Obj { get; } = obj;

        public List<DocuWare.Platform.ServerClient.ConfigurationRight> ConfigurationRight
        {
            get => Obj.ConfigurationRight;
            set => Obj.ConfigurationRight = value;
        }
    }
}
