using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeItEasy;
using NUnit.Framework;
using CFAServices;

namespace CFATests
{
    [TestFixture]
    public class CFAParseTest
    {
        private ICFAParseService _CFAParseService;
        private string[] Mock_Input = {
                                        "<>",
                                        "{}",
                                        "{{{}}}",
                                        "{{},{}}",
                                        "{{{},{},{{}}}}",
                                        "{<a>,<a>,<a>,<a>}",
                                        "{{<ab>},{<ab>},{<ab>},{<ab>}}",
                                        "{{<!!>},{<!!>},{<!!>},{<!!>}}",
                                        "{{<a!>},{<a!>},{<a!>},{<ab>}}"
                                      };
        private int[] Mock_Correct_Answer = { 0, 1, 6, 5, 16, 1, 9, 9, 3 };
        private int[] Mock_Wrong_Answer = { 100, 0, 0, 0, 0, 0, 0, 0, 0 };
        [OneTimeSetUp]
        public void Init()
        {
            _CFAParseService = new CFAParseService();

        }

        [Test]
        public void Test_CFAParseService_With_Fake_Input()
        {
            Assert.AreEqual(Mock_Correct_Answer[0], _CFAParseService.Calculator(Mock_Input[0]));
            Assert.AreEqual(Mock_Correct_Answer[1], _CFAParseService.Calculator(Mock_Input[1]));
            Assert.AreEqual(Mock_Correct_Answer[2], _CFAParseService.Calculator(Mock_Input[2]));
            Assert.AreEqual(Mock_Correct_Answer[3], _CFAParseService.Calculator(Mock_Input[3]));
            Assert.AreEqual(Mock_Correct_Answer[4], _CFAParseService.Calculator(Mock_Input[4]));
            Assert.AreEqual(Mock_Correct_Answer[5], _CFAParseService.Calculator(Mock_Input[5]));
            Assert.AreEqual(Mock_Correct_Answer[6], _CFAParseService.Calculator(Mock_Input[6]));
            Assert.AreEqual(Mock_Correct_Answer[7], _CFAParseService.Calculator(Mock_Input[7]));
            Assert.AreEqual(Mock_Correct_Answer[8], _CFAParseService.Calculator(Mock_Input[8]));
            //Wrong test
            //Assert.AreEqual(Mock_Wrong_Answer[0], _CFAParseService.Calculator(Mock_Input[0]));
            //Assert.AreEqual(Mock_Wrong_Answer[1], _CFAParseService.Calculator(Mock_Input[1]));
            //Assert.AreEqual(Mock_Wrong_Answer[2], _CFAParseService.Calculator(Mock_Input[2]));
            //Assert.AreEqual(Mock_Wrong_Answer[3], _CFAParseService.Calculator(Mock_Input[3]));
            //Assert.AreEqual(Mock_Wrong_Answer[4], _CFAParseService.Calculator(Mock_Input[4]));
            //Assert.AreEqual(Mock_Wrong_Answer[5], _CFAParseService.Calculator(Mock_Input[5]));
            //Assert.AreEqual(Mock_Wrong_Answer[6], _CFAParseService.Calculator(Mock_Input[6]));
            //Assert.AreEqual(Mock_Wrong_Answer[7], _CFAParseService.Calculator(Mock_Input[7]));
            //Assert.AreEqual(Mock_Wrong_Answer[8], _CFAParseService.Calculator(Mock_Input[8]));
            
        }


    }
}
