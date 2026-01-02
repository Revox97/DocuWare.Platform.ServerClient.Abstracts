using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class NumberTableColumnOptions(DocuWare.Platform.ServerClient.NumberTableColumnOptions obj) : INumberTableColumnOptions
    {
        internal DocuWare.Platform.ServerClient.NumberTableColumnOptions Obj { get; } = obj;

        public int Precision
        {
            get => Obj.Precision;
            set => Obj.Precision = value;
        }
    }
}
