using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialog
    {
		List<IDialogField> Fields { get; set; }
		bool HasValidation { get; set; }
		Link[] Links { get; set; }
		string Id { get; set; }
		string FileCabinetId { get; set; }
		string FileCabinetName { get; set; }
		string DisplayName { get; set; }
		bool IsForMobile { get; set; }
		string AssignedDialogId { get; set; }
		string Color { get; set; }
		bool IsDefault { get; set; }
		DocuWare.Platform.ServerClient.DialogTypes Type { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
