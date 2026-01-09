using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITrashBinSelectListExpression{3}
    {
		string FieldName { get; set; }
		int Count { get; set; }
		int Start { get; set; }
		SortDirection SortDirection { get; set; }
    }
}
