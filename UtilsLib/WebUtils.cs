namespace UtilsLib
{
    public static class WebUtils
    {
        // Removes "http(s)//", "wwww." and / at end 
        public static string TrimUrl(string url) => 
             url
                .TrimStart("http://")
                .TrimStart("https://")
                .TrimStart("wwww.")
                .TrimEnd('/');
    }
}