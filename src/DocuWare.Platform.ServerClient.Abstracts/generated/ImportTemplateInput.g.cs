using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ImportTemplateInput(DocuWare.Platform.ServerClient.ImportTemplateInput obj) : IImportTemplateInput
    {
        internal DocuWare.Platform.ServerClient.ImportTemplateInput Obj { get; } = obj;

        public string FileName
        {
            get => Obj.FileName;
            set => Obj.FileName = value;
        }

        public string FileData
        {
            get => Obj.FileData;
            set => Obj.FileData = value;
        }

        public string OrganizationID
        {
            get => Obj.OrganizationID;
            set => Obj.OrganizationID = value;
        }
    }
}
