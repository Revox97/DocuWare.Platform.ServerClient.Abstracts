using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStampField{3}
    {
		string Name { get; set; }
		DWFieldType DWType { get; set; }
		int Length { get; set; }
		bool HasFixedEntry { get; set; }
    }
}
