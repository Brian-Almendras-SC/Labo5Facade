using NUnit.Framework;
using PracticeDesignPatternStructural.Class;

namespace WmaTest
{
    public class Tests
    {
        Sound AerosmithTrack1;
        Sound TrackConvert;
        string AnswerAux;
        [SetUp]
        public void Setup()
        {
            AerosmithTrack1 = new Wma();
            AerosmithTrack1.AssignamentToDetails(330, "Dream");
        }

        [Test]
        public void GetTypeOfSound()
        {
            Assert.AreEqual("Wma", AerosmithTrack1.ReturnTypeOfSound());
        }
        [Test]
        public void ConvertToWma()
        {
            TrackConvert = AerosmithTrack1.ConvertToMp3(AerosmithTrack1);
            Assert.AreEqual("Mp3", TrackConvert.ReturnTypeOfSound());
        }
    }
}