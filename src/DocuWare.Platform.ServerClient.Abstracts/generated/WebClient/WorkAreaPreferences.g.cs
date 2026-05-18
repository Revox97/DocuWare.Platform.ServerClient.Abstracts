using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.WebClient
{
    public class WorkAreaPreferences(SDK.WebClient.WorkAreaPreferences obj) : IWorkAreaPreferences
    {
        internal SDK.WebClient.WorkAreaPreferences Obj { get; } = obj;

        public List<IContentAreaPreferences> ContentAreas
        {
            get => Obj.ContentAreas.Select(x => new ContentAreaPreferences(x) as IContentAreaPreferences).ToList();
            set => Obj.ContentAreas = value.Select(x => ((ContentAreaPreferences)x).Obj).ToList();
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }
    }
}
