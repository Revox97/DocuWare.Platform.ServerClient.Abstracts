using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentApplicationProperty: IApplicationProperty
    {
		string Name { get; set; }
		string Value { get; set; }
    }
}
