using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IQueryParamater
    {
		string Name { get; set; }
		string IsRequired { get; set; }
		QueryParamaterType Type { get; set; }
    }
}
