using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFlagConditions{3}
    {
		bool IncludeCheckedOut { get; set; }
		bool IncludeAppended { get; set; }
    }
}
