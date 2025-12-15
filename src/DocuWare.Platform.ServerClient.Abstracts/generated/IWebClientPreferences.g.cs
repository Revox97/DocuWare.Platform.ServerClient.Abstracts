using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWebClientPreferences
    {
		List<IWorkAreaPreferences> WorkAreas { get; set; }
		IGeneralSettings GeneralSettings { get; set; }
		IWebClientLayout WebClientLayout { get; set; }
		IFavorites Favorites { get; set; }
		IViewerPreferences Viewer { get; set; }
		IMultiFCSearches MultiFCSearches { get; set; }
		string LocalStorage { get; set; }
		DateTime SurveyTimeStamp { get; set; }
    }
}
