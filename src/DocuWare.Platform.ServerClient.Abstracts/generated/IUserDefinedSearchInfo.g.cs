using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUserDefinedSearchInfo
    {
		IDialogExpression DialogExpression { get; set; }
		string Name { get; set; }
    }
}
