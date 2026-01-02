using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class NumberField(DocuWare.Platform.ServerClient.NumberField obj) : INumberField
    {
        internal DocuWare.Platform.ServerClient.NumberField Obj { get; } = obj;

        public double? MinValue
        {
            get => Obj.MinValue;
            set => Obj.MinValue = value;
        }

        public double? MaxValue
        {
            get => Obj.MaxValue;
            set => Obj.MaxValue = value;
        }

        public double? PredefinedCustomEntry
        {
            get => Obj.PredefinedCustomEntry;
            set => Obj.PredefinedCustomEntry = value;
        }
    }
}
