namespace EasyCSharpEncryptor.Data
{
	public struct PasswordGenerationData : IData
	{
		public int Length;
		public bool IncludeNumbers;
		public bool IncludeSymbols;
		public bool IncludeLowercase;
		public bool IncludeUppercase;
		public bool IncludeAmbiguous;
	}
}