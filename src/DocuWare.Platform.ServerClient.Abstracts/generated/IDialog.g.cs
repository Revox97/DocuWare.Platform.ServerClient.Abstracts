using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialog
    {
		List<IDialogField> Fields { get; set; }
		IDocumentsQuery Query { get; set; }
		IDialogProperties Properties { get; set; }
		IIntellixFieldAssignments IntellixFieldAssignments { get; set; }
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
		string SelfRelationLink { get; }
		string AssignedDialogRelationLink { get; }
		string CountRelationLink { get; }
		string SelectListRelationLink { get; }
		string StoreDocumentRelationLink { get; }
		string TransferRelationLink { get; }
		string CreateUserDefinedSearchRelationLink { get; }
		string ClientSideValidationRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
    }
}
