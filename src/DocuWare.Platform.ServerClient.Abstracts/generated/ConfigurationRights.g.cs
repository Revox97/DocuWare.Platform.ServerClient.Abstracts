using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ConfigurationRights(DocuWare.Platform.ServerClient.ConfigurationRights obj) : IConfigurationRights
    {
        internal DocuWare.Platform.ServerClient.ConfigurationRights Obj { get; } = obj;

        public List<ConfigurationRight> ConfigurationRight
        {
            get => Obj.ConfigurationRight.ConvertAll(o => (ConfigurationRight)o);
            set => Obj.ConfigurationRight = value.ConvertAll(v => (DocuWare.Platform.ServerClient.ConfigurationRight)v);
        }
    }
}
