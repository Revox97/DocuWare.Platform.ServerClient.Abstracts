using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITableHistoryFieldOptions
    {
		List<ITableColumnsDefinition> TableColumnsDefinitions { get; set; }
    }
}
