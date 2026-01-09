using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITableFieldColumns{3}
    {
		List<IFileCabinetFieldBase> TableFieldColumn { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
