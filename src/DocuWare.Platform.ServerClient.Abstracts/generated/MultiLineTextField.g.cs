using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MultiLineTextField(SDK.MultiLineTextField obj) : IMultiLineTextField
    {
        internal SDK.MultiLineTextField Obj { get; } = obj;

        public int? MinLength
        {
            get => Obj.MinLength;
            set => Obj.MinLength = value;
        }

        public int? MaxLength
        {
            get => Obj.MaxLength;
            set => Obj.MaxLength = value;
        }
    }
}
