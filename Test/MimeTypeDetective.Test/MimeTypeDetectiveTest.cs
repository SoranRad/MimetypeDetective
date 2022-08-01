using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using TwentyDevs.MimeTypeDetective;
using Xunit;

namespace MimeTypeDetective.Test
{

    public class MimeTypeDetectiveTest
    {
        [Fact]
        public void Test0010()
        {
            // arrange 
            var txtMimetype = new MimeTypeInfo(Array.Empty<byte?>(), "txt", "text/plain", "",false);
            var txtExtention = MimeTypeDetection.GetMimeTypeByExtention("txt");

            // act 
            var result = txtExtention == txtMimetype;

            // assert
            result.Should().BeTrue();

        }

        [Fact]
        public void Test0020()
        {
            // arrange 
            var txtMimetype = new MimeTypeInfo(Array.Empty<byte?>(), "txt", "text/plain", "", false);
            var txtExtention = MimeTypeDetection.GetMimeTypeinfoByMimetypestring("text/plain");

            // act 
            var result = txtExtention == txtMimetype;

            // assert
            result.Should().BeTrue();

        }



    }
}
