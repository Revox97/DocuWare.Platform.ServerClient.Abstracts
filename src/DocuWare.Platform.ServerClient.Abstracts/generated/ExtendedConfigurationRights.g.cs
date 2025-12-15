using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExtendedConfigurationRights(SDK.ExtendedConfigurationRights obj) : IExtendedConfigurationRights
    {
        internal SDK.ExtendedConfigurationRights Obj { get; } = obj;

		public bool Forms
		{
			get => Obj.Forms;
			set => Obj.Forms = value;
		}
    }
}
