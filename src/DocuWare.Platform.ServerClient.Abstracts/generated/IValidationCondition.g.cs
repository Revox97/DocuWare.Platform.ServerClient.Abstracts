using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IValidationCondition : IFormCondition
    {
		ComparisonType ComparisonType { get; set; }
    }
}
