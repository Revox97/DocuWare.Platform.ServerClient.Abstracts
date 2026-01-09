using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ILine : IRectangleBase
    {
		List<object> Items { get; set; }
		bool bold { get; set; }
		int fontSize { get; set; }
		int BaseLine { get; set; }
    }
}
