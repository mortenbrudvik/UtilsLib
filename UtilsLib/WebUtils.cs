using System;
using LanguageExt;

using static LanguageExt.Prelude;

namespace UtilsLib
{
    public static class WebUtils
    {
        public static Try<string> TrimUrl(string url) => 
            Try(() =>
            {
                var uri = new Uri(url);
                return (uri.Host.TrimStart("www.") + uri.PathAndQuery + uri.Fragment).TrimEnd('/');
            });
    }
}