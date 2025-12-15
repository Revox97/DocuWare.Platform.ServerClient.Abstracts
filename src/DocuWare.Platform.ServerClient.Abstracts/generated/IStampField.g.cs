using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStampField
    {
		IDocumentIndexFieldValue Value { get; set; }
		string Name { get; set; }
		DocuWare.Platform.ServerClient.DWFieldType DWType { get; set; }
		int Length { get; set; }
		bool HasFixedEntry { get; set; }
    }
}
