using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IResultDialogFunction{3}
    {
		ResultDialogFunctionType Type { get; set; }
		bool InToolBar { get; set; }
		bool AsButton { get; set; }
    }
}
