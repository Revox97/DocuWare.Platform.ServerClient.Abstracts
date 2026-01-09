using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileCabinetSelectListExpression{3}
    {
		string FieldName { get; set; }
		int Count { get; set; }
		int Start { get; set; }
		int Limit { get; set; }
		SortDirection SortDirection { get; set; }
		bool Typed { get; set; }
    }
}
