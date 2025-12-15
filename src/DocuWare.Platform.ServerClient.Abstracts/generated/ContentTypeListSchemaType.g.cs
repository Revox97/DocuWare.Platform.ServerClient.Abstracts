using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ContentTypeListSchemaType(SDK.ContentTypeListSchemaType obj) : IContentTypeListSchemaType
    {
        internal SDK.ContentTypeListSchemaType Obj { get; } = obj;

		public string IntroducedIn
		{
			get => Obj.IntroducedIn;
			set => Obj.IntroducedIn = value;
		}

		public XmlQualifiedName Value
		{
			get => Obj.Value;
			set => Obj.Value = value;
		}
    }
}
