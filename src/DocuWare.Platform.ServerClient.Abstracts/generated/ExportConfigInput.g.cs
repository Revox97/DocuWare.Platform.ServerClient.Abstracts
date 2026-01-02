using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExportConfigInput(DocuWare.Platform.ServerClient.ExportConfigInput obj) : IExportConfigInput
    {
        internal DocuWare.Platform.ServerClient.ExportConfigInput Obj { get; } = obj;

        public string ConfigGUID
        {
            get => Obj.ConfigGUID;
            set => Obj.ConfigGUID = value;
        }

        public string OrganizationID
        {
            get => Obj.OrganizationID;
            set => Obj.OrganizationID = value;
        }
    }
}
