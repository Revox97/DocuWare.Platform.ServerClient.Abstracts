using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MultiLineTextField(DocuWare.Platform.ServerClient.MultiLineTextField obj) : IMultiLineTextField
    {
        internal DocuWare.Platform.ServerClient.MultiLineTextField Obj { get; } = obj;

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
