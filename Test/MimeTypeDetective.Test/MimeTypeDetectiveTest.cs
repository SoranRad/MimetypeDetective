﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var txtMimetype = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x00, 0x14, 0x66, 0x74, 0x79, 0x70 }, "3gp", "video/3gpp", "",false);
            var txtExtention = MimeTypeDetection.GetMimeTypeByExtension("3gp");

            // act 
            var result = txtExtention == txtMimetype;

            // assert
            result.Should().BeTrue();

        }

        [Fact]
        public void Test0020()
        {
            // arrange 
            var txtMimetype = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x00, 0x14, 0x66, 0x74, 0x79, 0x70 },  "3gp", "video/3gpp", "", false);
            var txtExtention = MimeTypeDetection.GetMimeTypeinfoByMimetypeString("video/3gpp");

            // act 
            var result = txtExtention == txtMimetype;

            // assert
            result.Should().BeTrue();

        }

        // Test Async Methods
        [Fact]
        public async Task Test0030_Async()
        {
            // arrange 
            var txtMimetype  = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x00, 0x14, 0x66, 0x74, 0x79, 0x70 }, "3gp", "video/3gpp", "", false);
            var txtExtention = await MimeTypeDetection.GetMimeTypeAsync(new byte[] { 0x00, 0x00, 0x00, 0x14, 0x66, 0x74, 0x79, 0x70 });

            // act 
            var result = txtExtention == txtMimetype;

            // assert
            result.Should().BeTrue();

        }

        // Test Async Methods
        [Fact]
        public void Test0030()
        {
            // arrange 
            var txtMimetype = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x00, 0x14, 0x66, 0x74, 0x79, 0x70 }, "3gp", "video/3gpp", "", false);
            var txtExtention =  MimeTypeDetection.GetMimeType(new byte[] { 0x00, 0x00, 0x00, 0x14, 0x66, 0x74, 0x79, 0x70 });

            // act 
            var result = txtExtention == txtMimetype;

            // assert
            result.Should().BeTrue();

        }


    }
}
