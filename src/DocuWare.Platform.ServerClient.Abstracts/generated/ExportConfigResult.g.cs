using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExportConfigResult(DocuWare.Platform.ServerClient.ExportConfigResult obj) : IExportConfigResult
    {
        internal DocuWare.Platform.ServerClient.ExportConfigResult Obj { get; } = obj;

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
    }
}
