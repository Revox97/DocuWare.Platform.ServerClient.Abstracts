using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ConfigurationRights(SDK.ConfigurationRights obj) : IConfigurationRights
    {
        internal SDK.ConfigurationRights Obj { get; } = obj;

		public List<ConfigurationRight> ConfigurationRight
		{
			get => Obj.ConfigurationRight.Select(x => new onfigurationRight(x) as ConfigurationRight).ToList();
			set => Obj.ConfigurationRight = value.Select(x => ((onfigurationRight)x).Obj).ToList();
		}
    }
}
