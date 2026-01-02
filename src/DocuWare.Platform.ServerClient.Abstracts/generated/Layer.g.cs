using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Layer(DocuWare.Platform.ServerClient.Layer obj) : ILayer
    {
        internal DocuWare.Platform.ServerClient.Layer Obj { get; } = obj;

        public List<IEntryBase> Items
        {
            get => Obj.Items.Select(x => new EntryBase(x) as IEntryBase).ToList();
            set => Obj.Items = value.Select(x => ((EntryBase)x).Obj).ToList();
        }

        public int Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }
    }
}
