using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFieldValueStatisticsExpression
    {
		string FieldName { get; set; }
		int Limit { get; set; }
    }
}
