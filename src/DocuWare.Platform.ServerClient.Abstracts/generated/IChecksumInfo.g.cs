using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IChecksumInfo{3}
    {
		string ChecksumValue { get; set; }
		string ChecksumAlgorithm { get; set; }
    }
}
