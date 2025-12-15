using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentIndexFieldTableRow
    {
		List<IDocumentIndexField> ColumnValue { get; set; }
    }
}
