using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IResultDialogFunction
    {
		ResultDialogFunctionType Type { get; set; }
		bool InToolBar { get; set; }
		bool AsButton { get; set; }
    }
}
