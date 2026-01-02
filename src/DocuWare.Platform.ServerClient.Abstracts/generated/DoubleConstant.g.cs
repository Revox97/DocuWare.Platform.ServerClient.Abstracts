using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DoubleConstant(DocuWare.Platform.ServerClient.DoubleConstant obj) : IDoubleConstant
    {
        internal DocuWare.Platform.ServerClient.DoubleConstant Obj { get; } = obj;

        public double? Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
