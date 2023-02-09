namespace CS.Extensions
{
    public static class StringExtension
    {
        public static string ToUpperFirstLetter(this string str)
        {
            return string.IsNullOrEmpty(str) ? str : char.ToUpper(str[0]) + str.Substring(1);
        }

        public static string ToCamelCase(this string str)
        {
            return string.IsNullOrEmpty(str) || str.Length < 2 ? str.ToLowerInvariant() : char.ToLowerInvariant(str[0]) + str.Substring(1);
        }
        public static string GetHashString(this string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(s.ToLower().Trim()))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }
    }

}
