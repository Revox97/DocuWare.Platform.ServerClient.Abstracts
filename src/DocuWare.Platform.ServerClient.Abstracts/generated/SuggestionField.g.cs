using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SuggestionField(SDK.SuggestionField obj) : ISuggestionField
    {
        internal SDK.SuggestionField Obj { get; } = obj;

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

		public IntellixFieldTrust Confidence
		{
			get => new ntellixFieldTrust(Obj.Confidence);
			set => Obj.Confidence = ((ntellixFieldTrust)value).Obj;
		}
    }
}
