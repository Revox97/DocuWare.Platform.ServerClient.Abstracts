using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITableFieldColumns
    {
		List<IFileCabinetFieldBase> TableFieldColumn { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
