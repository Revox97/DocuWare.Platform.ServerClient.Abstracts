using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Rights(SDK.Rights obj) : IRights
    {
        internal SDK.Rights Obj { get; } = obj;

		public List<Right> Right
		{
			get => Obj.Right.Select(x => new ight(x) as Right).ToList();
			set => Obj.Right = value.Select(x => ((ight)x).Obj).ToList();
		}
    }
}
