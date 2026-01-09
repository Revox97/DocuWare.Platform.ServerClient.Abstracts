using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ILinkForm: IBaseForm
    {
		string Url { get; set; }
		FormTypeEnum FormFieldType { get; set; }
		string Label { get; set; }
		int Id { get; set; }
    }
}
