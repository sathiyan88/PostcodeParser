using System;
using FFX_PostCode_Parser;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FFX_PostCode_Parser_UnitTest
{
    [TestClass]
    public class PostCodeParserUnitTest
    {
        [TestMethod]
        public void PostCodeValidationTestMethodOne()
        {
           bool actualResult= PostCodeParser.CheckPostCodeValidation("M28 7JP");
            Assert.AreEqual(true, actualResult);
        }

        [TestMethod]
        public void PostCodeValidationTestMethodTwo()
        {
            bool actualResult = PostCodeParser.CheckPostCodeValidation("WC2H7DE");
            Assert.AreEqual(true, actualResult);

        }

        [TestMethod]
        public void PostCodeValidationTestMethodThree()
        {
            bool actualResult = PostCodeParser.CheckPostCodeValidation("CT21 4LR");
            Assert.AreEqual(true, actualResult);
        }

        [TestMethod]
        public void PostCodeValidationTestMethodFour()
        {
            bool actualResult = PostCodeParser.CheckPostCodeValidation("N33DP");
            Assert.AreEqual(true, actualResult);
        }

    }
}
