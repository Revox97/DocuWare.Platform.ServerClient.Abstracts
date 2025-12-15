using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Position(SDK.Position obj) : IPosition
    {
        internal SDK.Position Obj { get; } = obj;

		public int x
		{
			get => Obj.x;
			set => Obj.x = value;
		}

		public int y
		{
			get => Obj.y;
			set => Obj.y = value;
		}

		public int width
		{
			get => Obj.width;
			set => Obj.width = value;
		}

		public int height
		{
			get => Obj.height;
			set => Obj.height = value;
		}
    }
}
