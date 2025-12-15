using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SimplePageContent(SDK.SimplePageContent obj) : ISimplePageContent
    {
        internal SDK.SimplePageContent Obj { get; } = obj;

        public List<ISimpleWord> W
        {
            get => Obj.W.Select(x => new SimpleWord(x) as ISimpleWord).ToList();
            set => Obj.W = value.Select(x => ((SimpleWord)x).Obj).ToList();
        }
    }
}
