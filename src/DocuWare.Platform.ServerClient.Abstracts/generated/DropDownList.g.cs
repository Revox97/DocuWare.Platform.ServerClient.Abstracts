using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DropDownList(DocuWare.Platform.ServerClient.DropDownList obj) : IDropDownList
    {
        internal DocuWare.Platform.ServerClient.DropDownList Obj { get; } = obj;

        public List<string> Options
        {
            get => Obj.Options;
            set => Obj.Options = value;
        }
    }
}
