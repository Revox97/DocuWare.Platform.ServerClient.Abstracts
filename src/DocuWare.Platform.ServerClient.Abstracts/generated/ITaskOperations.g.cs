using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITaskOperations
    {
		IBaseTaskOperations BaseTaskOperations { get; set; }
		IExtendedControllerOperations ExtendedControllerOperations { get; set; }
		IExtendedUserOperations ExtendedUserOperations { get; set; }
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
