using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ApplicationPreferences(DocuWare.Platform.ServerClient.WebClient.ApplicationPreferences obj) : IApplicationPreferences
    {
        internal DocuWare.Platform.ServerClient.WebClient.ApplicationPreferences Obj { get; } = obj;
    }
}
