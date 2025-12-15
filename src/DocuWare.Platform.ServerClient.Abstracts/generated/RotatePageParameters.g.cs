using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RotatePageParameters(SDK.RotatePageParameters obj) : IRotatePageParameters
    {
        internal SDK.RotatePageParameters Obj { get; } = obj;

		public int SectionNumber
		{
			get => Obj.SectionNumber;
			set => Obj.SectionNumber = value;
		}

		public int PageNumber
		{
			get => Obj.PageNumber;
			set => Obj.PageNumber = value;
		}

		public int Rotation
		{
			get => Obj.Rotation;
			set => Obj.Rotation = value;
		}
    }
}
