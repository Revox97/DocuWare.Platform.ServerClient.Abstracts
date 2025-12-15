using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SizedAnnotationToolSettings(SDK.SizedAnnotationToolSettings obj) : ISizedAnnotationToolSettings
    {
        internal SDK.SizedAnnotationToolSettings Obj { get; } = obj;

		public int LineSize
		{
			get => Obj.LineSize;
			set => Obj.LineSize = value;
		}

		public AnnotationTools Type
		{
			get => new nnotationTools(Obj.Type);
			set => Obj.Type = ((nnotationTools)value).Obj;
		}

		public string Color
		{
			get => Obj.Color;
			set => Obj.Color = value;
		}
    }
}
