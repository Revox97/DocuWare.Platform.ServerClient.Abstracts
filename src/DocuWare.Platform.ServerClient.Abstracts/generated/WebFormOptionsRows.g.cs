using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebFormOptionsRows(DocuWare.Platform.ServerClient.WebFormOptionsRows obj) : IWebFormOptionsRows
    {
        internal DocuWare.Platform.ServerClient.WebFormOptionsRows Obj { get; } = obj;

        public List<List<IWebFormOption>> WebFormOptions
        {
            get
            {
                List<List<IWebFormOption>> result = new();

                foreach (var outer in Obj.WebFormOptions)
                    result.Add(new(from inner in outer select new WebFormOption(inner)));

                return result;
            }
            set
            {
                List<List<SDK.WebFormOption>> result = new();

                foreach (var outer in value)
                    result.Add(new(from inner in outer select ((WebFormOption)inner).Obj));

                Obj.WebFormOptions = result;
            }
        }
    }
}
