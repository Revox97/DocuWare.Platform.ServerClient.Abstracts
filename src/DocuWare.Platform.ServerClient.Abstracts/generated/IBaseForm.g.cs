using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBaseForm{3}
    {
		FormTypeEnum FormFieldType { get; set; }
		string Label { get; set; }
		int Id { get; set; }
    }
}
