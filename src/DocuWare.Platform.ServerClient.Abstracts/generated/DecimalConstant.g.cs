using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DecimalConstant(SDK.DecimalConstant obj) : IDecimalConstant
    {
        internal SDK.DecimalConstant Obj { get; } = obj;

        public Decimal? Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
