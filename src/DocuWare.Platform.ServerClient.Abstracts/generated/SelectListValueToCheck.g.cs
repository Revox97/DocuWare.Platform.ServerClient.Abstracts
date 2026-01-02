using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SelectListValueToCheck(DocuWare.Platform.ServerClient.SelectListValueToCheck obj) : ISelectListValueToCheck
    {
        internal DocuWare.Platform.ServerClient.SelectListValueToCheck Obj { get; } = obj;

        public string Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }

        public string Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }
    }
}
