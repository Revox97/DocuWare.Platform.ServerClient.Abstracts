using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class NumberTableColumnOptions(SDK.NumberTableColumnOptions obj) : INumberTableColumnOptions
    {
        internal SDK.NumberTableColumnOptions Obj { get; } = obj;

        public int Precision
        {
            get => Obj.Precision;
            set => Obj.Precision = value;
        }
    }
}
