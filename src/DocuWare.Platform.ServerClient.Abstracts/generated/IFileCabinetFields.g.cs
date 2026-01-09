using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileCabinetFields{3}
    {
		List<IFileCabinetField> Field { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
