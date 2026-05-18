using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IInstanceExpressionCondition
    {
		List<string> Value { get; set; }
		string DBName { get; set; }
    }
}
