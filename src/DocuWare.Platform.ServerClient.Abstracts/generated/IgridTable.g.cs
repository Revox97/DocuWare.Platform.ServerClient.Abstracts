using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IgridTable
    {
		List<int> gridCol { get; set; }
		List<int> gridRow { get; set; }
    }
}
