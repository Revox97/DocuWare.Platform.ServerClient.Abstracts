using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStampField
    {
		string Name { get; set; }
		DocuWare.Platform.ServerClient.DWFieldType DWType { get; set; }
		int Length { get; set; }
		bool HasFixedEntry { get; set; }
    }
}
