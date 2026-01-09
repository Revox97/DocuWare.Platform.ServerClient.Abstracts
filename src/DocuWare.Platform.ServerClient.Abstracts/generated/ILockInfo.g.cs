using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ILockInfo
    {
		string Interval { get; set; }
		string Operation { get; set; }
    }
}
