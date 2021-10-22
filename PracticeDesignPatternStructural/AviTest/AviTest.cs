using NUnit.Framework;
using PracticeDesignPatternStructural.Class;

namespace AviTest
{
    public class Tests
    {
        Video IpmanMovie1;
        Video VideoConverter;
        string AnswerAux;
        [SetUp]
        public void Setup()
        {
            IpmanMovie1 = new Avi();
            IpmanMovie1.AssignamentToDetails(15500, "Ip Man ", new Wma());
        }

        [Test]
        public void GetTypeOfVideo()
        {
            Assert.AreEqual("Avi", IpmanMovie1.ReturnTypeOfVideo());
        }
        [Test]
        public void GetTypeOfVideoAndSound()
        {
            AnswerAux = "Formato del video: Avi, Formato del sonido: Wma";
            Assert.AreEqual(AnswerAux, IpmanMovie1.ReturnTypeOfVideoAndSound());
        }
        [Test]
        public void ConvertToMp4()
        {
            VideoConverter = IpmanMovie1.ConvertToMp4(IpmanMovie1);
            Assert.AreEqual("Mp4", VideoConverter.ReturnTypeOfVideo());
        }
        [Test]
        public void ExtractToTypeOfSound()
        {
            AnswerAux = IpmanMovie1.ExtractSound().ReturnTypeOfSound();
            Assert.AreEqual("Wma", AnswerAux);
        }
    }
}