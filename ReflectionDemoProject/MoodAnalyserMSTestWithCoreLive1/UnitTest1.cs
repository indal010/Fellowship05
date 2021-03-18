using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserAppWithCoreLive1;

namespace MoodAnalyserMSTestWithCoreLive1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
             string message = null;
             //object obj1 = new MoodAnalyser();
            
            object expected = new MoodAnalyser(message);
            object obj =MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserAppWithCoreLive1.MoodAnalyser", "MoodAnalyser");
            //expected.Equals(obj);
            Assert.AreEqual(expected.GetType(), obj.GetType());
        }

        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserAppWithCore.MoodAnalyser", "MoodAnalyser", "SAD");
            expected.Equals(obj);
        }

    }
}
