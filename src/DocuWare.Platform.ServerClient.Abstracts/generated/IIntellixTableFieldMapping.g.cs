using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IIntellixTableFieldMapping{3}
    {
		List<IIntellixTableFieldColumnMapping> TableFieldColumnMapping { get; set; }
		string FieldDBName { get; set; }
    }
}
