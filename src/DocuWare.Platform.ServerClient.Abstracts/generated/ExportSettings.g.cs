using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExportSettings(DocuWare.Platform.ServerClient.ExportSettings obj) : IExportSettings
    {
        internal DocuWare.Platform.ServerClient.ExportSettings Obj { get; } = obj;

        public bool IncludeDataFiles
        {
            get => Obj.IncludeDataFiles;
            set => Obj.IncludeDataFiles = value;
        }

        public bool ExportHistory
        {
            get => Obj.ExportHistory;
            set => Obj.ExportHistory = value;
        }

        public bool ExportTextshots
        {
            get => Obj.ExportTextshots;
            set => Obj.ExportTextshots = value;
        }
    }
}
