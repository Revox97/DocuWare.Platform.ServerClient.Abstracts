using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICountExpression
    {
		IDialogExpression DialogExpression { get; set; }
		string FieldName { get; set; }
		int Limit { get; set; }
    }
}
