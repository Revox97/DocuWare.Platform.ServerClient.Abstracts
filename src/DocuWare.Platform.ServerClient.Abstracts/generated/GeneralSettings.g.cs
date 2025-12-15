using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class GeneralSettings(SDK.GeneralSettings obj) : IGeneralSettings
    {
        internal SDK.GeneralSettings Obj { get; } = obj;

		public WorkAreaType StartWith
		{
			get => new orkAreaType(Obj.StartWith);
			set => Obj.StartWith = ((orkAreaType)value).Obj;
		}

		public string CreatedVersion
		{
			get => Obj.CreatedVersion;
			set => Obj.CreatedVersion = value;
		}
    }
}
