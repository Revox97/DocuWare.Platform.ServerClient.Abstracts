using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RadioGroup(SDK.RadioGroup obj) : IRadioGroup
    {
        internal SDK.RadioGroup Obj { get; } = obj;

        public List<IWebFormOption> Options
        {
            get => Obj.Options.Select(x => new WebFormOption(x) as IWebFormOption).ToList();
            set => Obj.Options = value.Select(x => ((WebFormOption)x).Obj).ToList();
        }

        public List<List<IWebFormOption>> OptionsRows
        {
            get => Obj.OptionsRows;
            set => Obj.OptionsRows = value;
        }
    }
}
