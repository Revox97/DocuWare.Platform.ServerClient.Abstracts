using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileCabinetField : IFileCabinetFieldBase
    {
		List<IFileCabinetFieldBase> TableFieldColumns { get; set; }
		bool UsedAsDocumentName { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
