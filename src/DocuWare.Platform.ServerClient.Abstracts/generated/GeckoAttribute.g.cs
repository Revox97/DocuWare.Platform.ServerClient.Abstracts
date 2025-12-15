using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class GeckoAttribute(SDK.GeckoAttribute obj) : IGeckoAttribute
    {
        internal SDK.GeckoAttribute Obj { get; } = obj;

		public string MinumumVersion
		{
			get => Obj.MinumumVersion;
			set => Obj.MinumumVersion = value;
		}

		public Object TypeId => Obj.TypeId;
    }
}
