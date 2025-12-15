using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class LinkParameter(SDK.LinkParameter obj) : ILinkParameter
    {
        internal SDK.LinkParameter Obj { get; } = obj;

		public string Url
		{
			get => Obj.Url;
			set => Obj.Url = value;
		}

		public string Label
		{
			get => Obj.Label;
			set => Obj.Label = value;
		}
    }
}
