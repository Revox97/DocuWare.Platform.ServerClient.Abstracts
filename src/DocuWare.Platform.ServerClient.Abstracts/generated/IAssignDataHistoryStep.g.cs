using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAssignDataHistoryStep
    {
		List<IHistoryField> Fields { get; set; }
		List<IFileCabinetHistoryField> FileCabinetFields { get; set; }
		List<IConditionHistoryStep> Conditions { get; set; }
    }
}
