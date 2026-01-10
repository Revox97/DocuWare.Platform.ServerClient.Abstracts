using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ResultListQuery(DocuWare.Platform.ServerClient.ResultListQuery obj) : IResultListQuery
    {
        internal DocuWare.Platform.ServerClient.ResultListQuery Obj { get; } = obj;

        public List<ISortedField> SortOrder
        {
            get => Obj.SortOrder.Select(x => new SortedField(x) as ISortedField).ToList();
            set => Obj.SortOrder = value.Select(x => ((SortedField)x).Obj).ToList();
        }

        public List<string> AdditionalResultFields
        {
            get => Obj.AdditionalResultFields;
            set => Obj.AdditionalResultFields = value;
        }

        public IFlagConditions FlagConditions
        {
            get => new FlagConditions(Obj.FlagConditions);
            set => Obj.FlagConditions = ((FlagConditions)value).Obj;
        }

        public int Start
        {
            get => Obj.Start;
            set => Obj.Start = value;
        }

        public int Count
        {
            get => Obj.Count;
            set => Obj.Count = value;
        }

        public bool ExcludeDefaultSystemFields
        {
            get => Obj.ExcludeDefaultSystemFields;
            set => Obj.ExcludeDefaultSystemFields = value;
        }

        public bool WithoutLinks
        {
            get => Obj.WithoutLinks;
            set => Obj.WithoutLinks = value;
        }

        public bool IncludeSuggestions
        {
            get => Obj.IncludeSuggestions;
            set => Obj.IncludeSuggestions = value;
        }

        public bool CalculateTotalCount
        {
            get => Obj.CalculateTotalCount;
            set => Obj.CalculateTotalCount = value;
        }
    }
}
