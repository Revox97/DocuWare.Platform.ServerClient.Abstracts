using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SuggestionField(DocuWare.Platform.ServerClient.SuggestionField obj) : ISuggestionField
    {
        internal DocuWare.Platform.ServerClient.SuggestionField Obj { get; } = obj;

        public List<ISuggestionValue> Value
        {
            get => Obj.Value.Select(x => new SuggestionValue(x) as ISuggestionValue).ToList();
            set => Obj.Value = value.Select(x => ((SuggestionValue)x).Obj).ToList();
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public string DBName
        {
            get => Obj.DBName;
            set => Obj.DBName = value;
        }

        public DocuWare.Platform.ServerClient.IntellixFieldTrust Confidence
        {
            get => Obj.Confidence;
            set => Obj.Confidence = value;
        }
    }
}
