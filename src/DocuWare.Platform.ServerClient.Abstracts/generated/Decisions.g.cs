using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Decisions(DocuWare.Platform.ServerClient.Decisions obj) : IDecisions
    {
        internal DocuWare.Platform.ServerClient.Decisions Obj { get; } = obj;

        public List<IDecision> Decision
        {
            get => Obj.Decision.Select(x => new Decision(x) as IDecision).ToList();
            set => Obj.Decision = value.Select(x => ((Decision)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
