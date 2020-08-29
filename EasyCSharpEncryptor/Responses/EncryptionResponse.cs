namespace EasyCSharpEncryptor.Responses
{
	public enum EncryptionResponse : uint
	{
		Success = 0,
		PasswordIsEmpty,
		SourceIsEmpty,
		SaltIsEmpty,
		SaltIsIncorrect,
		SaltIsLessThan8Bytes,
		SaltIsMoreThan32Bytes,
		DecryptionFail,
	}
}