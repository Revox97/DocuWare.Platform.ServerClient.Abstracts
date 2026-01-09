using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IQueryParamater{3}
    {
		string Name { get; set; }
		string IsRequired { get; set; }
		QueryParamaterType Type { get; set; }
    }
}
