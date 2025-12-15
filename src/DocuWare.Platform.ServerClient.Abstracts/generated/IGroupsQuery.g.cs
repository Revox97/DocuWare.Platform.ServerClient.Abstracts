using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IGroupsQuery
    {
		bool Active { get; set; }
		bool ActiveSpecified { get; set; }
		string Name { get; set; }
    }
}
