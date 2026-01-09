using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IImportSettings
    {
		List<IFieldMapping> FieldMappings { get; set; }
		bool PreserveSystemFields { get; set; }
    }
}
