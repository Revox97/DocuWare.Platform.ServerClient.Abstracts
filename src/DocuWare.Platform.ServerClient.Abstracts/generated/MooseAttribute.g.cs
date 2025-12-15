using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MooseAttribute(SDK.MooseAttribute obj) : IMooseAttribute
    {
        internal SDK.MooseAttribute Obj { get; } = obj;

		public string MinumumVersion
		{
			get => Obj.MinumumVersion;
			set => Obj.MinumumVersion = value;
		}

		public Object TypeId => Obj.TypeId;
    }
}
