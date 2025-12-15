using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ApplicationPreferencesHolder(SDK.ApplicationPreferencesHolder obj) : IApplicationPreferencesHolder
    {
        internal SDK.ApplicationPreferencesHolder Obj { get; } = obj;

        public IApplicationPreferences AppPrefs
        {
            get => new ApplicationPreferences(Obj.AppPrefs);
            set => Obj.AppPrefs = ((ApplicationPreferences)value).Obj;
        }
    }
}
