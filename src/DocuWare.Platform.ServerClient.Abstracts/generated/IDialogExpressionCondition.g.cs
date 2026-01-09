using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogExpressionCondition{3}
    {
		List<string> Value { get; set; }
		string DBName { get; set; }
		string ColumnName { get; set; }
    }
}
