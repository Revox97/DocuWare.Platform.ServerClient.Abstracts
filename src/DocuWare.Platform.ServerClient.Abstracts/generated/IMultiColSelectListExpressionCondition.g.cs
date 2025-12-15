using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IMultiColSelectListExpressionCondition
    {
		string Value { get; set; }
		string ColumnName { get; set; }
		string Type { get; set; }
    }
}
