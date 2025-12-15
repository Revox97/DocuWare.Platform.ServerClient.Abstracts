using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MultiColSelectListRow(SDK.MultiColSelectListRow obj) : IMultiColSelectListRow
    {
        internal SDK.MultiColSelectListRow Obj { get; } = obj;

        public List<object> Items
        {
            get => Obj.Items;
            set => Obj.Items = value;
        }
    }
}
