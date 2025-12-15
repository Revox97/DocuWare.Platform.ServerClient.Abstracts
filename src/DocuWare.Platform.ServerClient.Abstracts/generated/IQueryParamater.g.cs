using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IQueryParamater
    {
		string Name { get; set; }
		string IsRequired { get; set; }
		DocuWare.Platform.ServerClient.QueryParamaterType Type { get; set; }
    }
}
