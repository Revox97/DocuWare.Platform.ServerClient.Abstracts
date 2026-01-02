using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SuggestionTableField(DocuWare.Platform.ServerClient.SuggestionTableField obj) : ISuggestionTableField
    {
        internal DocuWare.Platform.ServerClient.SuggestionTableField Obj { get; } = obj;

        public List<ISuggestionTable> Table
        {
            get => Obj.Table.Select(x => new SuggestionTable(x) as ISuggestionTable).ToList();
            set => Obj.Table = value.Select(x => ((SuggestionTable)x).Obj).ToList();
        }

        public string DBName
        {
            get => Obj.DBName;
            set => Obj.DBName = value;
        }

        public IntellixFieldTrust Confidence
        {
            get => (IntellixFieldTrust)Obj.Confidence;
            set => Obj.Confidence = (DocuWare.Platform.ServerClient.IntellixFieldTrust)value;
        }
    }
}
