using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExportTemplateInput(DocuWare.Platform.ServerClient.ExportTemplateInput obj) : IExportTemplateInput
    {
        internal DocuWare.Platform.ServerClient.ExportTemplateInput Obj { get; } = obj;

        public string ConfigGUID
        {
            get => Obj.ConfigGUID;
            set => Obj.ConfigGUID = value;
        }

        public string TemplateGUID
        {
            get => Obj.TemplateGUID;
            set => Obj.TemplateGUID = value;
        }

        public string OrganizationID
        {
            get => Obj.OrganizationID;
            set => Obj.OrganizationID = value;
        }
    }
}
