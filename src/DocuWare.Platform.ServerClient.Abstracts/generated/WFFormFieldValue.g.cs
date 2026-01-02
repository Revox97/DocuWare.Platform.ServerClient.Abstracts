using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WFFormFieldValue(DocuWare.Platform.ServerClient.WFFormFieldValue obj) : IWFFormFieldValue
    {
        internal DocuWare.Platform.ServerClient.WFFormFieldValue Obj { get; } = obj;

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }
    }
}
