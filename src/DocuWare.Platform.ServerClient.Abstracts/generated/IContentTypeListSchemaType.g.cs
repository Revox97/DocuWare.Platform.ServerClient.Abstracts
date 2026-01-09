using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IContentTypeListSchemaType
    {
		string IntroducedIn { get; set; }
		XmlQualifiedName Value { get; set; }
    }
}
