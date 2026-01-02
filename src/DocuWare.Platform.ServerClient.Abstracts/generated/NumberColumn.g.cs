using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class NumberColumn(DocuWare.Platform.ServerClient.NumberColumn obj) : INumberColumn
    {
        internal DocuWare.Platform.ServerClient.NumberColumn Obj { get; } = obj;

        public int Precision
        {
            get => Obj.Precision;
            set => Obj.Precision = value;
        }
    }
}
