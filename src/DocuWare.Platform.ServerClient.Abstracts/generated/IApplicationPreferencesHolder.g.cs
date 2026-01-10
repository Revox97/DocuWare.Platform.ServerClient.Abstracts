using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IApplicationPreferencesHolder
    {
		IApplicationPreferences AppPrefs { get; set; }
    }
}
