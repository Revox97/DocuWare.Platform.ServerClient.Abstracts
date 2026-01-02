using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ImportConfigInput(DocuWare.Platform.ServerClient.ImportConfigInput obj) : IImportConfigInput
    {
        internal DocuWare.Platform.ServerClient.ImportConfigInput Obj { get; } = obj;

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
