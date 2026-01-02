using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MultiColSelectListColumn(DocuWare.Platform.ServerClient.MultiColSelectListColumn obj) : IMultiColSelectListColumn
    {
        internal DocuWare.Platform.ServerClient.MultiColSelectListColumn Obj { get; } = obj;

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public string Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }
    }
}
