namespace UtilsLib
{
    public static class StringExt
    {
        public static string TrimStart(this string target, string trimChars) => 
            target.TrimStart(trimChars.ToCharArray());

        public static string TrimEnd(this string target, string trimChars) => 
            target.TrimEnd(trimChars.ToCharArray());
    }
}