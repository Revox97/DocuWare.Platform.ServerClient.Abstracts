using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFunctionExpression
    {
		List<IAnyExpression> Parameter { get; set; }
		string Name { get; set; }
    }
}
