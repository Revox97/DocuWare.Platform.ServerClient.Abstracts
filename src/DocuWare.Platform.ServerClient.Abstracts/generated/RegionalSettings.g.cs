using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RegionalSettings(SDK.RegionalSettings obj) : IRegionalSettings
    {
        internal SDK.RegionalSettings Obj { get; } = obj;

        public string Language
        {
            get => Obj.Language;
            set => Obj.Language = value;
        }

        public string Culture
        {
            get => Obj.Culture;
            set => Obj.Culture = value;
        }

        public string Calendar
        {
            get => Obj.Calendar;
            set => Obj.Calendar = value;
        }
    }
}
