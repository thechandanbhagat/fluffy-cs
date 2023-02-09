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
    }

}
