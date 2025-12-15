using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Decisions(SDK.Decisions obj) : IDecisions
    {
        internal SDK.Decisions Obj { get; } = obj;

		public List<IDecision> Decision
		{
			get => Obj.Decision.Select(x => new Decision(x) as IDecision).ToList();
			set => Obj.Decision = value.Select(x => ((Decision)x).Obj).ToList();
		}

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
