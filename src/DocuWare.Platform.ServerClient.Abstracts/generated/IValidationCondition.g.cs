using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IValidationCondition
    {
		DocuWare.Platform.ServerClient.ComparisonType ComparisonType { get; set; }
		string FieldID { get; set; }
		DocuWare.Platform.ServerClient.Operator Operator { get; set; }
		string Value { get; set; }
		DocuWare.Platform.ServerClient.Continuation Continuation { get; set; }
    }
}
