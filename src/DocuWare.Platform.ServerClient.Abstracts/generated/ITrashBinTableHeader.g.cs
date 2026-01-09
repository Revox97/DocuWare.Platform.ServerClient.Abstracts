using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITrashBinTableHeader
    {
		string FieldName { get; set; }
		string Type { get; set; }
		string Label { get; set; }
    }
}
