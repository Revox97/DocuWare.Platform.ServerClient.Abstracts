using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITrashBinSelectListExpression
    {
		string ValuePrefix { get; set; }
		ITrashBinExpression Expression { get; set; }
		string FieldName { get; set; }
		int Count { get; set; }
		int Start { get; set; }
		DocuWare.Platform.ServerClient.SortDirection SortDirection { get; set; }
    }
}
