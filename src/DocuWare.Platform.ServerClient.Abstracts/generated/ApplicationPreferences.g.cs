using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ApplicationPreferences(SDK.ApplicationPreferences obj) : IApplicationPreferences
    {
        internal SDK.ApplicationPreferences Obj { get; } = obj;
    }
}
