using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SimplePageContent(DocuWare.Platform.ServerClient.Content.SimplePageContent obj) : ISimplePageContent
    {
        internal DocuWare.Platform.ServerClient.Content.SimplePageContent Obj { get; } = obj;

        public List<ISimpleWord> W
        {
            get => Obj.W.Select(x => new SimpleWord(x) as ISimpleWord).ToList();
            set => Obj.W = value.Select(x => ((SimpleWord)x).Obj).ToList();
        }
    }
}
