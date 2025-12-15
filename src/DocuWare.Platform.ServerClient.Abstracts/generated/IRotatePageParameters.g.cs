using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRotatePageParameters
    {
		int SectionNumber { get; set; }
		int PageNumber { get; set; }
		int Rotation { get; set; }
    }
}
