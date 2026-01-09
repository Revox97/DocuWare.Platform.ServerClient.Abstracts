using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IHistoryStepInfo: IHistoryStepInfoBase
    {
		object Item { get; set; }
    }
}
