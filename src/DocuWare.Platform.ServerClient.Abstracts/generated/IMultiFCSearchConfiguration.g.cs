using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IMultiFCSearchConfiguration
    {
		List<string> FcIds { get; set; }
		string Name { get; set; }
		string SearchDialogID { get; set; }
		string SearchDialogFCID { get; set; }
		Guid Id { get; set; }
    }
}
