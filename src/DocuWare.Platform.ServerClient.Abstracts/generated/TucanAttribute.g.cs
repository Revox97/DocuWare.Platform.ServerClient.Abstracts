using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TucanAttribute(SDK.TucanAttribute obj) : ITucanAttribute
    {
        internal SDK.TucanAttribute Obj { get; } = obj;

		public string MinumumVersion
		{
			get => Obj.MinumumVersion;
			set => Obj.MinumumVersion = value;
		}

		public Object TypeId => Obj.TypeId;
    }
}
