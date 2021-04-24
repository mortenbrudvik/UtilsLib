using System;
using FluentAssertions;
using Xunit;

using static UtilsLib.WebUtils;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TrimUrl_ShouldRemoveProtocolAndWWWAndSlashAtEnd_WhenValidUrl()
        {
            const string url = "http://www.google.com/";

            TrimUrl(url)
                .Match(
                    url => url.Should().Be("google.com"),
                    _ => Assert.False(true));
        }
    }
}
