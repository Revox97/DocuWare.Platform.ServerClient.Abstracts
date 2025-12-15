using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SortedFieldsList(SDK.SortedFieldsList obj) : ISortedFieldsList
    {
        internal SDK.SortedFieldsList Obj { get; } = obj;

		public List<ISortedField> OrderBy
		{
			get => Obj.OrderBy.Select(x => new SortedField(x) as ISortedField).ToList();
			set => Obj.OrderBy = value.Select(x => ((SortedField)x).Obj).ToList();
		}
    }
}
