using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DropDownList(SDK.DropDownList obj) : IDropDownList
    {
        internal SDK.DropDownList Obj { get; } = obj;

        public List<string> Options
        {
            get => Obj.Options;
            set => Obj.Options = value;
        }
    }
}
