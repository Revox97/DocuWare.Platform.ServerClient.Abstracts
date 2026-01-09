using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IChecksumInfo
    {
		string ChecksumValue { get; set; }
		string ChecksumAlgorithm { get; set; }
    }
}
