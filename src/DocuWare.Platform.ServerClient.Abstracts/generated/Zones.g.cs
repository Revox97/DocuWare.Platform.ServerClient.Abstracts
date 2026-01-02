using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Zones(DocuWare.Platform.ServerClient.Zones obj) : IZones
    {
        internal DocuWare.Platform.ServerClient.Zones Obj { get; } = obj;

        public List<IZone> Zone
        {
            get => Obj.Zone.Select(x => new Zone(x) as IZone).ToList();
            set => Obj.Zone = value.Select(x => ((Zone)x).Obj).ToList();
        }
    }
}
