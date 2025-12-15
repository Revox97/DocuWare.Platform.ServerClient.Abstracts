using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IHistoryStep
    {
		IHistoryStepInfo Info { get; set; }
		int StepNumber { get; set; }
		DateTime StepDate { get; set; }
		string ActivityName { get; set; }
		string ActivityType { get; set; }
		DocuWare.Platform.ServerClient.StepTypeEnum StepType { get; set; }
    }
}
