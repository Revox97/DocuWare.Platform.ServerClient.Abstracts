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

        public DateTime SurveyTimeStamp
        {
            get => Obj.SurveyTimeStamp;
            set => Obj.SurveyTimeStamp = value;
        }
    }
}
