using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebClientPreferences(SDK.WebClientPreferences obj) : IWebClientPreferences
    {
        internal SDK.WebClientPreferences Obj { get; } = obj;

        public List<IWorkAreaPreferences> WorkAreas
        {
            get => Obj.WorkAreas.Select(x => new WorkAreaPreferences(x) as IWorkAreaPreferences).ToList();
            set => Obj.WorkAreas = value.Select(x => ((WorkAreaPreferences)x).Obj).ToList();
        }

        public IGeneralSettings GeneralSettings
        {
            get => new GeneralSettings(Obj.GeneralSettings);
            set => Obj.GeneralSettings = ((GeneralSettings)value).Obj;
        }

        public IWebClientLayout WebClientLayout
        {
            get => new WebClientLayout(Obj.WebClientLayout);
            set => Obj.WebClientLayout = ((WebClientLayout)value).Obj;
        }

        public IFavorites Favorites
        {
            get => new Favorites(Obj.Favorites);
            set => Obj.Favorites = ((Favorites)value).Obj;
        }

        public IViewerPreferences Viewer
        {
            get => new ViewerPreferences(Obj.Viewer);
            set => Obj.Viewer = ((ViewerPreferences)value).Obj;
        }

        public IMultiFCSearches MultiFCSearches
        {
            get => new MultiFCSearches(Obj.MultiFCSearches);
            set => Obj.MultiFCSearches = ((MultiFCSearches)value).Obj;
        }

        public string LocalStorage
        {
            get => Obj.LocalStorage;
            set => Obj.LocalStorage = value;
        }

        public DateTime SurveyTimeStamp
        {
            get => Obj.SurveyTimeStamp;
            set => Obj.SurveyTimeStamp = value;
        }
    }
}
