using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CellZone(SDK.CellZone obj) : ICellZone
    {
        internal SDK.CellZone Obj { get; } = obj;

		public ITextZone TextZone
		{
			get => new TextZone(Obj.TextZone);
			set => Obj.TextZone = ((TextZone)value).Obj;
		}

		public int L
		{
			get => Obj.L;
			set => Obj.L = value;
		}

		public int T
		{
			get => Obj.T;
			set => Obj.T = value;
		}

		public int W
		{
			get => Obj.W;
			set => Obj.W = value;
		}

		public int H
		{
			get => Obj.H;
			set => Obj.H = value;
		}
    }
}
