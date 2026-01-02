using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CountResultItem(DocuWare.Platform.ServerClient.CountResultItem obj) : ICountResultItem
    {
        internal DocuWare.Platform.ServerClient.CountResultItem Obj { get; } = obj;

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public int Count
        {
            get => Obj.Count;
            set => Obj.Count = value;
        }
    }
}
