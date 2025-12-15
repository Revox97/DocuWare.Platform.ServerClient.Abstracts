using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IConditionHistoryStep
    {
		string OutputName { get; set; }
		bool Taken { get; set; }
    }
}
