using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class InputSections(DocuWare.Platform.ServerClient.InputSections obj) : IInputSections
    {
        internal DocuWare.Platform.ServerClient.InputSections Obj { get; } = obj;

        public List<IInputSection> Section
        {
            get => Obj.Section.Select(x => new InputSection(x) as IInputSection).ToList();
            set => Obj.Section = value.Select(x => ((InputSection)x).Obj).ToList();
        }
    }
}
