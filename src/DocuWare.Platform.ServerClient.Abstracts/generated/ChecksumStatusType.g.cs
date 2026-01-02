namespace DocuWare.Platform.ServerClient.Abstracts
{
    public enum ChecksumStatusType
    {
		NotChecked = 0,
		Ok = 1,
		NoChecksum = 2,
		WrongChecksum = 3,
		FailedToCheck = 4
    }
}
