using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ApplicationPreferencesHolder(DocuWare.Platform.ServerClient.WebClient.ApplicationPreferencesHolder obj) : IApplicationPreferencesHolder
    {
        internal DocuWare.Platform.ServerClient.WebClient.ApplicationPreferencesHolder Obj { get; } = obj;

        public IApplicationPreferences AppPrefs
        {
            get => new ApplicationPreferences(Obj.AppPrefs);
            set => Obj.AppPrefs = ((ApplicationPreferences)value).Obj;
        }
    }
}
