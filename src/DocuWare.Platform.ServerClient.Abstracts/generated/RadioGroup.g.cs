using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RadioGroup(DocuWare.Platform.ServerClient.RadioGroup obj) : IRadioGroup
    {
        internal DocuWare.Platform.ServerClient.RadioGroup Obj { get; } = obj;

        public List<IWebFormOption> Options
        {
            get => Obj.Options.Select(x => new WebFormOption(x) as IWebFormOption).ToList();
            set => Obj.Options = value.Select(x => ((WebFormOption)x).Obj).ToList();
        }

        public List<List<IWebFormOption>> OptionsRows
        {
            get
            {
                List<List<IWebFormOption>> result = new();

                foreach (var outer in Obj.OptionsRows)
                    result.Add(new(from inner in outer select new WebFormOption(inner)));

                return result;
            }
            set
            {
                List<List<SDK.WebFormOption>> result = new();

                foreach (var outer in value)
                    result.Add(new(from inner in outer select ((WebFormOption)inner).Obj));

                Obj.OptionsRows = result;
            }
        }
    }
}
