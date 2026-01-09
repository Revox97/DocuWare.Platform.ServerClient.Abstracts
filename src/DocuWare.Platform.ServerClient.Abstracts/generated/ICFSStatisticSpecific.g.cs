using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICFSStatisticSpecific{3}
    {
		List<ICFSSpecificValue> SpecificValue { get; set; }
		CFSTableNames Category { get; set; }
		string ObjectID { get; set; }
    }
}
