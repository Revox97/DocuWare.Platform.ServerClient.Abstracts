using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBehaviorCondition
    {
		string FieldID { get; set; }
		DocuWare.Platform.ServerClient.Operator Operator { get; set; }
		string Value { get; set; }
		DocuWare.Platform.ServerClient.Continuation Continuation { get; set; }
    }
}
