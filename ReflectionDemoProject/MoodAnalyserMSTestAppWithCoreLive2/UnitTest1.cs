using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserAppWithCoreLive2;

namespace MoodAnalyserMSTestAppWithCoreLive2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserAppWithCoreLive2.MoodAnalyser", "MoodAnalyser");
            //expected.Equals(obj);
            Assert.AreEqual(expected.GetType(),obj.GetType());

        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserAppWithCoreLive2.MoodAnalyser", "MoodAnalyser");
            //expected.Equals(obj);
            Assert.AreEqual(expected.GetType(), obj.GetType());
        }
    }
}
