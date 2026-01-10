using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ConfirmedField(DocuWare.Platform.ServerClient.ConfirmedField obj) : IConfirmedField
    {
        internal DocuWare.Platform.ServerClient.ConfirmedField Obj { get; } = obj;

        public IWFFormFieldValue Value
        {
            get => new WFFormFieldValue(Obj.Value);
            set => Obj.Value = ((WFFormFieldValue)value).Obj;
        }

        public int Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }
    }
}
