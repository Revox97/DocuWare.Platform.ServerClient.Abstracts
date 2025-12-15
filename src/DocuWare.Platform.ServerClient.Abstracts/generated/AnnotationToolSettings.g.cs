using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AnnotationToolSettings(SDK.AnnotationToolSettings obj) : IAnnotationToolSettings
    {
        internal SDK.AnnotationToolSettings Obj { get; } = obj;

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
