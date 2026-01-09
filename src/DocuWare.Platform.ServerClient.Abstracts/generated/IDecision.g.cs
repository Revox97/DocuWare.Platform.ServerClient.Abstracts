using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDecision
    {
		List<ITaskFormField> TaskFormField { get; set; }
		Link[] Links { get; set; }
		int Id { get; set; }
		string Description { get; set; }
		string Label { get; set; }
		string Color { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
