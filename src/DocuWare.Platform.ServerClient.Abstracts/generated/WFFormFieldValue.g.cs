using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WFFormFieldValue(SDK.WFFormFieldValue obj) : IWFFormFieldValue
    {
        internal SDK.WFFormFieldValue Obj { get; } = obj;

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }
    }
}
