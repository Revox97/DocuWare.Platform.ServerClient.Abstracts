using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ConfigurationRights(SDK.ConfigurationRights obj) : IConfigurationRights
    {
        internal SDK.ConfigurationRights Obj { get; } = obj;

        public List<DocuWare.Platform.ServerClient.ConfigurationRight> ConfigurationRight
        {
            get => Obj.ConfigurationRight;
            set => Obj.ConfigurationRight = value;
        }
    }
}
