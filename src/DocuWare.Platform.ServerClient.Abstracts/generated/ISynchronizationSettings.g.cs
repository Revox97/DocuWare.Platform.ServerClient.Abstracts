using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISynchronizationSettings{3}
    {
		List<IFieldMapping> FieldMappings { get; set; }
		SynchronizationOperation SynchronizationOperation { get; set; }
		int Id { get; set; }
		bool PreserveSystemFields { get; set; }
		bool ImportNotMappedFields { get; set; }
		bool SynchronizeFiles { get; set; }
    }
}
