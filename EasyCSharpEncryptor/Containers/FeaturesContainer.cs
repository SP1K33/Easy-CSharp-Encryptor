using EasyCSharpEncryptor.Data;
using EasyCSharpEncryptor.Features;
namespace EasyCSharpEncryptor.Containers
{
	public static class FeaturesContainer
	{
		public static PasswordGenerator PasswordGenerator { get; private set; }
		public static Cryptor Cryptor { get; private set; }
		public static DataContainer DataContainer { get; private set; }

		public static void CreateFeatures()
		{
			DataContainer = new DataContainer();
			PasswordGenerator = new PasswordGenerator();
			Cryptor = new Cryptor();
		}
	}
}
