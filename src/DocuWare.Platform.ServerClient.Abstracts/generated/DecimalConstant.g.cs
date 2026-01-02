using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DecimalConstant(DocuWare.Platform.ServerClient.DecimalConstant obj) : IDecimalConstant
    {
        internal DocuWare.Platform.ServerClient.DecimalConstant Obj { get; } = obj;

        public Decimal? Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
