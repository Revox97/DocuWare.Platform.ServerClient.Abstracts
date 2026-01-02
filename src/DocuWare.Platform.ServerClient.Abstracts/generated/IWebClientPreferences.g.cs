using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWebClientPreferences
    {
		List<IWorkAreaPreferences> WorkAreas { get; set; }
		DateTime SurveyTimeStamp { get; set; }
    }
}
