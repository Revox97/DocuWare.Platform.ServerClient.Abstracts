using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWorkflowStampsSettings
    {
		IFont InfoFontFamily { get; set; }
		IFont StampFont { get; set; }
		bool UseFrame { get; set; }
		bool UseDate { get; set; }
		bool UseTime { get; set; }
		bool IsSignature { get; set; }
		bool UseUserName { get; set; }
		bool UseDecisionName { get; set; }
		bool UseActivityName { get; set; }
    }
}
