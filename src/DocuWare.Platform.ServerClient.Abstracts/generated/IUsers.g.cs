using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUsers{3}
    {
		List<IUser> User { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
