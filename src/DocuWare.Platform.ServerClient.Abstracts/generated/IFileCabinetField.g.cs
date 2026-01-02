using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileCabinetField
    {
		List<IFileCabinetFieldBase> TableFieldColumns { get; set; }
		bool UsedAsDocumentName { get; set; }
		Link[] Links { get; set; }
		DocuWare.Platform.ServerClient.FileCabinetFieldScope Scope { get; set; }
		DocuWare.Platform.ServerClient.DWFieldType DWFieldType { get; set; }
		int Length { get; set; }
		string DBFieldName { get; set; }
		string DisplayName { get; set; }
		bool DropLeadingZero { get; set; }
		bool DropLeadingBlanks { get; set; }
		bool NotEmpty { get; set; }
		int Precision { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
