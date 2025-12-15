using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDescriptionFormField
    {
		List<ILinkParameter> LinkParameters { get; set; }
		string DescriptionText { get; set; }
		DocuWare.Platform.ServerClient.FormTypeEnum FormFieldType { get; set; }
		string Label { get; set; }
		int Id { get; set; }
    }
}
