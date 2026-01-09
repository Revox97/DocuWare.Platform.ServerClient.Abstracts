using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRegionalSettings{3}
    {
		string Language { get; set; }
		string Culture { get; set; }
		string Calendar { get; set; }
    }
}
