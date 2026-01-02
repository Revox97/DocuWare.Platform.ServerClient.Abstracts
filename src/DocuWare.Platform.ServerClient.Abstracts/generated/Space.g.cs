using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Space(DocuWare.Platform.ServerClient.Content.Space obj) : ISpace
    {
        internal DocuWare.Platform.ServerClient.Content.Space Obj { get; } = obj;

        public int W
        {
            get => Obj.W;
            set => Obj.W = value;
        }
    }
}
