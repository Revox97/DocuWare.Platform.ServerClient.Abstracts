using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IImportSettings{3}
    {
		List<IFieldMapping> FieldMappings { get; set; }
		bool PreserveSystemFields { get; set; }
    }
}
