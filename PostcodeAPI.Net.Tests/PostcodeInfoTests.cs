﻿using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostcodeAPI;
using PostcodeAPI.Model;
using PostcodeAPI.Wrappers;

namespace PostcodeAPI.Tests
{
    [TestClass]
    public class PostcodeInfoTests : TestBase
    {
        [TestMethod]
        public void GetLargePostcodeSet()
        {
            PostcodeApiClient client = new PostcodeApiClient(ApiKey);
            ApiHalResultWrapper result = client.GetPostcodes("1097");

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Links.Self);
            Assert.IsNotNull(result.Links.Next);
            Assert.IsTrue(result.Embedded.Postcodes.Count == 20);
            Assert.AreEqual("Amsterdam", result.Embedded.Postcodes[0].City.Label);
        }

        [TestMethod]
        public void GetSinglePostcodeInformation()
        {
            PostcodeApiClient client = new PostcodeApiClient(ApiKey);
            PostcodeArea result = client.GetPostcode("1097JR");

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Streets.Count);
            Assert.AreEqual("Pierre Lallementstraat", result.Streets[0]);
            Assert.AreEqual("Amsterdam", result.City.Label);
        }
    }
}
