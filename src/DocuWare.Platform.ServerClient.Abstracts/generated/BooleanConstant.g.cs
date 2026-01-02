using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BooleanConstant(DocuWare.Platform.ServerClient.BooleanConstant obj) : IBooleanConstant
    {
        internal DocuWare.Platform.ServerClient.BooleanConstant Obj { get; } = obj;

        public bool? Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
