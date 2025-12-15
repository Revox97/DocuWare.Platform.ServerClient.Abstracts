using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class InputSections(SDK.InputSections obj) : IInputSections
    {
        internal SDK.InputSections Obj { get; } = obj;

		public List<IInputSection> Section
		{
			get => Obj.Section.Select(x => new InputSection(x) as IInputSection).ToList();
			set => Obj.Section = value.Select(x => ((InputSection)x).Obj).ToList();
		}
    }
}
