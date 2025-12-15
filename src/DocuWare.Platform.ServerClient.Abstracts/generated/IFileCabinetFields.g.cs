using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileCabinetFields
    {
		List<IFileCabinetField> Field { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
