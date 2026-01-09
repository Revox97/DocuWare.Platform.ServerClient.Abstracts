using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogInfos{3}
    {
		List<IDialogInfo> Dialog { get; set; }
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDialogInfos GetDialogInfosFromSelfRelation();
		Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromSelfRelationAsync(CancellationToken cancellationToken);
    }
}
