using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class EnhanceImageParameters(SDK.EnhanceImageParameters obj) : IEnhanceImageParameters
    {
        internal SDK.EnhanceImageParameters Obj { get; } = obj;

		public int SectionNumber
		{
			get => Obj.SectionNumber;
			set => Obj.SectionNumber = value;
		}
    }
}
