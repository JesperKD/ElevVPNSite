namespace ElevVPNClassLibrary.Security.Cryptography.Hashing.Generators
{
    public class SaltGeneratorFactory
    {
        public static ISaltGenerator GetSaltGenerator() => new SaltGenerator();
    }
}
