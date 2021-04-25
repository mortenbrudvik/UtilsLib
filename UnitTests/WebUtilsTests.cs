using System;
using FluentAssertions;
using Xunit;

using static UtilsLib.WebUtils;

namespace UnitTests
{
    public class WebUtilsTests
    {
        [Fact]
        public void TrimUrl_httpAndWwwAndSlashAtEndShouldAlwaysBeRemoved()
        {
            TrimUrl("http://www.google.com/")
                .Should().Be("google.com");
            
            TrimUrl("www.google.com/")
                .Should().Be("google.com");
            
            TrimUrl("google.com/")
                .Should().Be("google.com");
            
            TrimUrl("google.com")
                .Should().Be("google.com");

            TrimUrl("google.com/testing?q=2&b=3")
                .Should().Be("google.com/testing?q=2&b=3");
        }
    }
}
