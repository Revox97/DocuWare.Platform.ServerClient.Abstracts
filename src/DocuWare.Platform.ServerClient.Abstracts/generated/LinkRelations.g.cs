using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class LinkRelations(DocuWare.Platform.ServerClient.LinkRelations obj) : ILinkRelations
    {
        internal DocuWare.Platform.ServerClient.LinkRelations Obj { get; } = obj;

        public List<ILinkRelation> Relation
        {
            get => Obj.Relation.Select(x => new LinkRelation(x) as ILinkRelation).ToList();
            set => Obj.Relation = value.Select(x => ((LinkRelation)x).Obj).ToList();
        }

        public bool IsComplete
        {
            get => Obj.IsComplete;
            set => Obj.IsComplete = value;
        }
    }
}
