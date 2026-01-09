using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISelectListValuesQuery{3}
    {
		int Start { get; set; }
		int Count { get; set; }
		string ValuePrefix { get; set; }
		string ReturnType { get; set; }
    }
}
