using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISelectListExpression
    {
		IDialogExpression DialogExpression { get; set; }
		string ValuePrefix { get; set; }
		string FieldName { get; set; }
		int Count { get; set; }
		int Start { get; set; }
		int Limit { get; set; }
		SortDirection SortDirection { get; set; }
		bool ExcludeExternal { get; set; }
		bool Typed { get; set; }
    }
}
