using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IImportSettings
    {
		string MediaType { get; }
		List<IFieldMapping> FieldMappings { get; set; }
		bool PreserveSystemFields { get; set; }
    }
}
