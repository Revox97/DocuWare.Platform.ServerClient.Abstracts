using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class LobsterAttribute(SDK.LobsterAttribute obj) : ILobsterAttribute
    {
        internal SDK.LobsterAttribute Obj { get; } = obj;

		public string MinumumVersion
		{
			get => Obj.MinumumVersion;
			set => Obj.MinumumVersion = value;
		}

		public Object TypeId => Obj.TypeId;
    }
}
