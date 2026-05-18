using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Zones(SDK.Zones obj) : IZones
    {
        internal SDK.Zones Obj { get; } = obj;

        public List<IZone> Zone
        {
            get => Obj.Zone.Select(x => new Zone(x) as IZone).ToList();
            set => Obj.Zone = value.Select(x => ((Zone)x).Obj).ToList();
        }
    }
}
