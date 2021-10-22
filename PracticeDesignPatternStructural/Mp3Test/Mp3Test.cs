using NUnit.Framework;
using PracticeDesignPatternStructural.Class;

namespace Mp3Test
{
    public class Tests
    {
        Sound AerosmithTrack1;
        Sound TrackConvert;
        string AnswerAux;
        [SetUp]
        public void Setup()
        {
            AerosmithTrack1 = new Mp3();
            AerosmithTrack1.AssignamentToDetails(330, "Dream");
        }

        [Test]
        public void GetTypeOfSound()
        {
            Assert.AreEqual("Mp3", AerosmithTrack1.ReturnTypeOfSound());
        }
        [Test]
        public void ConvertToWma()
        {
            TrackConvert = AerosmithTrack1.ConvertToWma(AerosmithTrack1);
            Assert.AreEqual("Wma", TrackConvert.ReturnTypeOfSound());
        }
    }
}