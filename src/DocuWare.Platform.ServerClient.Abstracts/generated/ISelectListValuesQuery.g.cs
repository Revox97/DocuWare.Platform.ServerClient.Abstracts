using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISelectListValuesQuery
    {
		int Start { get; set; }
		int Count { get; set; }
		string ValuePrefix { get; set; }
		string ReturnType { get; set; }
    }
}
