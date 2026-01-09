using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICountExpression
    {
		string FieldName { get; set; }
		int Limit { get; set; }
    }
}
