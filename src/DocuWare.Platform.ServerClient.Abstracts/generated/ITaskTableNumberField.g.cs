using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITaskTableNumberField : ITaskNumberField
    {
		bool PrefillWithBalance { get; set; }
		string BalanceField { get; set; }
    }
}
