using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Space(SDK.Space obj) : ISpace
    {
        internal SDK.Space Obj { get; } = obj;

        public int W
        {
            get => Obj.W;
            set => Obj.W = value;
        }
    }
}
