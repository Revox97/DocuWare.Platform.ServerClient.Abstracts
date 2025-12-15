using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Words(SDK.Words obj) : IWords
    {
        internal SDK.Words Obj { get; } = obj;

		public List<IWord> Wd
		{
			get => Obj.Wd.Select(x => new Word(x) as IWord).ToList();
			set => Obj.Wd = value.Select(x => ((Word)x).Obj).ToList();
		}
    }
}
