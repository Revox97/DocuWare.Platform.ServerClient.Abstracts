using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TextField(DocuWare.Platform.ServerClient.TextField obj) : ITextField
    {
        internal DocuWare.Platform.ServerClient.TextField Obj { get; } = obj;

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
