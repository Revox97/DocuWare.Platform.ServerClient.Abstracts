using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITextZone : IRectangleBase
    {
		List<ILine> Ln { get; set; }
		string Lang { get; set; }
    }
}
