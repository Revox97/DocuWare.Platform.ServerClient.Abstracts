using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IHistoryStep{3}
    {
		int StepNumber { get; set; }
		DateTime StepDate { get; set; }
		string ActivityName { get; set; }
		string ActivityType { get; set; }
		StepTypeEnum StepType { get; set; }
    }
}
