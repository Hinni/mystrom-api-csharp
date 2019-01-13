using System;
using Xunit;

namespace MyStrom.Api.Test
{
    public class ClientTests
    {
        [Fact]
        public void UseIpAsBaseHost()
        {
            var testee = new Client(new Uri("http://192.168.254.1"));
            Assert.Equal("http://192.168.254.1/", testee.BaseHost);
        }
    }
}