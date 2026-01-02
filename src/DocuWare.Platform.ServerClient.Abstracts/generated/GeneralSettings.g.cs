using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class GeneralSettings(DocuWare.Platform.ServerClient.WebClient.GeneralSettings obj) : IGeneralSettings
    {
        internal DocuWare.Platform.ServerClient.WebClient.GeneralSettings Obj { get; } = obj;

        public WorkAreaType StartWith
        {
            get => (WorkAreaType)Obj.StartWith;
            set => Obj.StartWith = (DocuWare.Platform.ServerClient.WebClient.WorkAreaType)value;
        }

        public string CreatedVersion
        {
            get => Obj.CreatedVersion;
            set => Obj.CreatedVersion = value;
        }
    }
}
