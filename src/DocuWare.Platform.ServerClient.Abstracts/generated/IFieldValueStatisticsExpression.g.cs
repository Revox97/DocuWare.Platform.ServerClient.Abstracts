using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFieldValueStatisticsExpression{3}
    {
		string FieldName { get; set; }
		int Limit { get; set; }
    }
}
