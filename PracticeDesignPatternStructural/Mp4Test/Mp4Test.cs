using NUnit.Framework;
using PracticeDesignPatternStructural.Class;

namespace Mp4Test
{
    public class Tests
    {
        Video IpmanMovie1;
        Video VideoConverter;
        string AnswerAux;
        [SetUp]
        public void Setup()
        {
            IpmanMovie1 = new Mp4();
            IpmanMovie1.AssignamentToDetails(15500, "Ip Man ", new Wma());
        }

        [Test]
        public void GetTypeOfVideo()
        {
            Assert.AreEqual("Mp4",IpmanMovie1.ReturnTypeOfVideo());
        }
        [Test]
        public void GetTypeOfVideoAndSound()
        {
            AnswerAux = "Formato del video: Mp4, Formato del sonido: Wma";
            Assert.AreEqual(AnswerAux, IpmanMovie1.ReturnTypeOfVideoAndSound());
        }
        [Test]
        public void ConvertToAvi()
        {
            VideoConverter = IpmanMovie1.ConvertToAvi(IpmanMovie1);
            Assert.AreEqual("Avi", VideoConverter.ReturnTypeOfVideo());
        }
        [Test]
        public void ExtractToTypeOfSound()
        {
            AnswerAux = IpmanMovie1.ExtractSound().ReturnTypeOfSound();
            Assert.AreEqual("Wma",AnswerAux);
        }
    }
}