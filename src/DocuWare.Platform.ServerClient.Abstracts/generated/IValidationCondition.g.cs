using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IValidationCondition
    {
		ComparisonType ComparisonType { get; set; }
		string FieldID { get; set; }
		Operator Operator { get; set; }
		string Value { get; set; }
		Continuation Continuation { get; set; }
    }
}
