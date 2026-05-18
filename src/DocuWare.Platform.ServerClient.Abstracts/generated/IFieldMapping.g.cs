using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFieldMapping
    {
		List<IFieldMapping> ColumnMappings { get; set; }
		string Source { get; set; }
		string Destination { get; set; }
    }
}
