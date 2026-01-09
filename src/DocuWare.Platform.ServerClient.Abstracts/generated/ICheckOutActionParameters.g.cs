using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICheckOutActionParameters: IDocumentActionParameters
    {
		string FileCabinetId { get; set; }
    }
}
