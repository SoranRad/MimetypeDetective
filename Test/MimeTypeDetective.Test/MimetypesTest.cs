using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using TwentyDevs.MimeTypeDetective;
using Xunit;

namespace MimeTypeDetective.Test
{
    public class MimetypesTest
    {
        [Fact]
        public void Test0010()
        {
            // arrange 
            var mimetypeInfo  = new MimeTypeInfo(new byte?[] { 0x25, 0x26 }, 0, ".rar", " application   /   x-rar-compressed ", false);
            var mimetypeInfo2 = new MimeTypeInfo(new byte?[] { 0x25, 0x26 }, 0, ".rar", " application   /   x-rar-compressed ", false);

            // act 
            MimeTypes.Add(mimetypeInfo);
            var exist = MimeTypes.MimeTypeList.Any(x=>x==mimetypeInfo2);

            // assert
            exist.Should().Be(true);
        }

        [Fact]
        public void Test0020()
        {
            // arrange 
            var mimetypeInfo  = new MimeTypeInfo(new byte?[] { 0x25, 0x26 }, 0, ".rar", " application   /   x-rar-compressed ", false);
            var mimetypeInfo2 = new MimeTypeInfo(new byte?[] { 0x25, 0x26 }, 0, ".rar", " application   /   x-rar-compressed ", false);

            // act 
            MimeTypes.Add(mimetypeInfo);
            var exist = MimeTypes.MimeTypeList.Any(x => x == mimetypeInfo2);

            // assert 
            exist.Should().Be(true);
        }

        [Fact]
        public void Test0030()
        {
            // arrange 
            MimeTypes.Add(new byte?[] { 0x55, 0x66 }, 0, 2, "ffg", "application   /   x-rar-compressed", false);

            // act 
            var exist = MimeTypes.MimeTypeList.Any(x => x.Extension == "ffg");

            // assert 
            exist.Should().Be(false);
        }

        [Fact]
        public void Test0040()
        {
            // arrange 
            MimeTypes.Add(new byte?[] { 0x55, 0x66 }, 0, 2, "ffg", "application   /   x-rar-compressed", false);

            // act 
            var exist = MimeTypes.MimeTypeList.Any(x => x.Extension == ".ffg");

            // assert 
            exist.Should().Be(true);
        }



    }
}
