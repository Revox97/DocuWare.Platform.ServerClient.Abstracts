using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class GeneralSettings(SDK.GeneralSettings obj) : IGeneralSettings
    {
        internal SDK.GeneralSettings Obj { get; } = obj;

        public DocuWare.Platform.ServerClient.WorkAreaType StartWith
        {
            get => Obj.StartWith;
            set => Obj.StartWith = value;
        }

        public string CreatedVersion
        {
            get => Obj.CreatedVersion;
            set => Obj.CreatedVersion = value;
        }
    }
}
