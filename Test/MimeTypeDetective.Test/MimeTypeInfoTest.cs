using System;
using FluentAssertions;
using TwentyDevs.MimeTypeDetective;
using Xunit;

namespace MimeTypeDetective.Test
{
    public class MimeTypeInfoTest
    {
        [Fact]
        public void Test0010()
        {
            // arrange
            var mimetypeInfo = new MimeTypeInfo(null, 0, "RAR", "application / x-rar-compressed", false);
            // act
            var extention = mimetypeInfo.Extension;
            // assert

            extention.Should().Be(".rar");
        }

        [Fact]
        public void Test0020()
        {
            // arrange
            var mimetypeInfo = new MimeTypeInfo(null, 0, "RAR", "application / x-rar-compressed", false);
            // act
            var mimetype = mimetypeInfo.MimeType;
            // assert

            mimetype.Should().Be("application/x-rar-compressed");
        }

        [Fact]
        public void Test0030()
        {
            // arrange
            var mimetypeInfo = new MimeTypeInfo(null, 0, ".rar", " application   /   x-rar-compressed ", false);
            // act
            var mimetype = mimetypeInfo.MimeType;
            // assert

            mimetype.Should().Be("application/x-rar-compressed");
        }

        [Fact]
        public void Test0040()
        {
            // arrange
            var mimetypeInfo = new MimeTypeInfo(null, 0, ".rar", " application   /   x-rar-compressed ", false);
            var mimetypeInfo2 = new MimeTypeInfo(null, 0, "Rar", " application   /   x-rar-compressed ", false);
            // act
            var mimetype = mimetypeInfo.Equals(mimetypeInfo2);
            // assert
            mimetype.Should().Be(true);
        }

        [Fact]
        public void Test0050()
        {
            // arrange
            var mimetypeInfo = new MimeTypeInfo(null, 0, ".rar", " application   /   x-rar-compressed ", false);
            var mimetypeInfo2 = new MimeTypeInfo(null, 0, "zip", " application   /   x-rar-compressed ", false);
            // act
            var mimetype = mimetypeInfo.Equals(mimetypeInfo2);
            // assert
            mimetype.Should().Be(false);
        }

        [Fact]
        public void Test0051()
        {
            // arrange
            var mimetypeInfo = new MimeTypeInfo(new byte?[]{0x25,0x26}, 0, ".rar", " application   /   x-rar-compressed ", false);
            var mimetypeInfo2 = new MimeTypeInfo(new byte?[] { 0x28, 0x27 }, 0, "rar", " application   /   x-rar-compressed ", false);
            // act
            var mimetype = mimetypeInfo.Equals(mimetypeInfo2);
            // assert

            mimetype.Should().Be(false);
        }

        [Fact]
        public void Test0060()
        {
            // arrange
            var mimetypeInfo = new MimeTypeInfo(null, 0, ".rar", " application   /   x-rar-compressed ", false);
            var mimetypeInfo2 = new MimeTypeInfo(null, 0, "zip", " application   /   x-rar-compressed ", false);
            // act
            var mimetype = mimetypeInfo.EqualsByExtention(mimetypeInfo2);
            // assert

            mimetype.Should().Be(false);
        }

        [Fact]
        public void Test0070()
        {
            // arrange
            var mimetypeInfo = new MimeTypeInfo(null, 0, ".rar", " application   /   x-rar-compressed ", false);
            var mimetypeInfo2 = new MimeTypeInfo(null, 0, "zip", " Application/x-rar-compressed ", false);
            // act
            var mimetype = mimetypeInfo.EqualsByMimetype(mimetypeInfo2);
            // assert
            mimetype.Should().Be(true);
        }

        [Fact]
        public void Test0080()
        {
            // arrange
            var mimetypeInfo = new MimeTypeInfo(new byte?[] { 0x25, 0x26 }, 0, ".rar", " application   /   x-rar-compressed ", false);
            var mimetypeInfo2 = new MimeTypeInfo(new byte?[] { 0x28, 0x27 }, 0, "rar", " application   /   x-rar-compressed ", false);
            // act
            var mimetype = mimetypeInfo.EqualsByHeaderContent(mimetypeInfo2);
            // assert
            mimetype.Should().Be(false);
        }

        [Fact]
        public void Test0090()
        {
            // arrange
            var mimetypeInfo = new MimeTypeInfo(new byte?[] { 0x25, 0x26 }, 0, ".rar", " application   /   x-rar-compressed ", false);
            var mimetypeInfo2 = new MimeTypeInfo(new byte?[] { 0x25, 0x26 }, 0, "rar", " application   /   x-rar-compressed ", false);
            // act
            var mimetype = mimetypeInfo == mimetypeInfo2;
            // assert
            mimetype.Should().Be(true);
        }


    }
}
