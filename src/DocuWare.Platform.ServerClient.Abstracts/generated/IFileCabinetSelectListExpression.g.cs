using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileCabinetSelectListExpression
    {
		string ValuePrefix { get; set; }
		string FieldName { get; set; }
		int Count { get; set; }
		int Start { get; set; }
		int Limit { get; set; }
		DocuWare.Platform.ServerClient.SortDirection SortDirection { get; set; }
		bool Typed { get; set; }
    }
}
