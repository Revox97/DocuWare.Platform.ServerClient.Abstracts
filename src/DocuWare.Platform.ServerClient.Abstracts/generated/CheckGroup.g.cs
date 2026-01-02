using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CheckGroup(DocuWare.Platform.ServerClient.CheckGroup obj) : ICheckGroup
    {
        internal DocuWare.Platform.ServerClient.CheckGroup Obj { get; } = obj;

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

        public List<string> PredefinedValues
        {
            get => Obj.PredefinedValues;
            set => Obj.PredefinedValues = value;
        }
    }
}
