using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IIntellixFieldMapping
    {
		string FieldDBName { get; set; }
		string IntellixFieldName { get; set; }
    }
}
