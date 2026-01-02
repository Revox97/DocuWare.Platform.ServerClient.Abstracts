using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Sections(DocuWare.Platform.ServerClient.Sections obj) : ISections
    {
        internal DocuWare.Platform.ServerClient.Sections Obj { get; } = obj;

        public List<ISection> Section
        {
            get => Obj.Section.Select(x => new Section(x) as ISection).ToList();
            set => Obj.Section = value.Select(x => ((Section)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
