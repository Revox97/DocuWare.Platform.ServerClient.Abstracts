using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TrashBinQuery(SDK.TrashBinQuery obj) : ITrashBinQuery
    {
        internal SDK.TrashBinQuery Obj { get; } = obj;

        public List<ISortedField> SortOrder
        {
            get => Obj.SortOrder.Select(x => new SortedField(x) as ISortedField).ToList();
            set => Obj.SortOrder = value.Select(x => ((SortedField)x).Obj).ToList();
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

        public bool CalculateTotalCount
        {
            get => Obj.CalculateTotalCount;
            set => Obj.CalculateTotalCount = value;
        }
    }
}
