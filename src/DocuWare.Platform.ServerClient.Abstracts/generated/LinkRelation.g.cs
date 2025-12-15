using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class LinkRelation(SDK.LinkRelation obj) : ILinkRelation
    {
        internal SDK.LinkRelation Obj { get; } = obj;

        public List<ILinkInvoke> Invoke
        {
            get => Obj.Invoke.Select(x => new LinkInvoke(x) as ILinkInvoke).ToList();
            set => Obj.Invoke = value.Select(x => ((LinkInvoke)x).Obj).ToList();
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public string IntroducedIn
        {
            get => Obj.IntroducedIn;
            set => Obj.IntroducedIn = value;
        }
    }
}
