using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MultiColSelectListRow(DocuWare.Platform.ServerClient.MultiColSelectListRow obj) : IMultiColSelectListRow
    {
        internal DocuWare.Platform.ServerClient.MultiColSelectListRow Obj { get; } = obj;

        public List<object> Items
        {
            get => Obj.Items;
            set => Obj.Items = value;
        }
    }
}
