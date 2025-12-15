using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentApplicationProperty(SDK.DocumentApplicationProperty obj) : IDocumentApplicationProperty
    {
        internal SDK.DocumentApplicationProperty Obj { get; } = obj;

		public string Name
		{
			get => Obj.Name;
			set => Obj.Name = value;
		}

		public string Value
		{
			get => Obj.Value;
			set => Obj.Value = value;
		}
    }
}
