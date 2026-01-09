using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUsersByRole{3}
    {
		List<IUser> User { get; set; }
		string RoleId { get; set; }
		bool IncludeGroupUsers { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
