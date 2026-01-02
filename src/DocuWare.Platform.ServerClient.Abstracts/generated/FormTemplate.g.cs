using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormTemplate(SDK.FormTemplate obj) : IFormTemplate
    {
        internal SDK.FormTemplate Obj { get; } = obj;

        public List<IZone> Zones
        {
            get => Obj.Zones.Select(x => new Zone(x) as IZone).ToList();
            set => Obj.Zones = value.Select(x => ((Zone)x).Obj).ToList();
        }

        public List<string> ExcludedFileAttachments
        {
            get => Obj.ExcludedFileAttachments;
            set => Obj.ExcludedFileAttachments = value;
        }
    }
}
