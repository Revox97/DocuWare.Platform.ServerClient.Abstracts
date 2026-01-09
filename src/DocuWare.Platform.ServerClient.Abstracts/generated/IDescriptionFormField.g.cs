using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDescriptionFormField : IBaseForm
    {
		List<ILinkParameter> LinkParameters { get; set; }
		string DescriptionText { get; set; }
    }
}
