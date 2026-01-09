using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogPropertiesTaskList : IDialogPropertiesResultList
    {
		string ConditionString { get; set; }
		bool Private { get; set; }
		bool AutoRefresh { get; set; }
		int AutoRefreshPeriod { get; set; }
    }
}
