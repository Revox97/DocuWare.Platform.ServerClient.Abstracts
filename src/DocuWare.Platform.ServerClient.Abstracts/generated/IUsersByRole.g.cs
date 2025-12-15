using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUsersByRole
    {
		List<IUser> User { get; set; }
		string RoleId { get; set; }
		bool IncludeGroupUsers { get; set; }
		bool IncludeGroupUsersSpecified { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
