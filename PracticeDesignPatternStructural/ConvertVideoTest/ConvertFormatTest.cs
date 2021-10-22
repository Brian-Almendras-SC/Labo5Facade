using NUnit.Framework;
using PracticeDesignPatternStructural.Class;

namespace ConvertVideoTest
{
    public class Tests
    {
        ConvertVideo Interfaz;
        Sound AerosmithTrack1;
        Sound TrackConvert;
        Video IpmanMovie1;
        Video VideoConverter;
        string AnswerAux;
        [SetUp]
        public void Setup()
        {
            Interfaz = new ConvertVideo();
            AerosmithTrack1 = new Mp3();
            AerosmithTrack1.AssignamentToDetails(330, "Dream");
            IpmanMovie1 = new Avi();
            IpmanMovie1.AssignamentToDetails(15500, "Ip Man ", new Wma());
        }
        [Test]
        public void ChecktheFomatOFSound()
        {
            AnswerAux = AerosmithTrack1.ReturnTypeOfSound();
            Assert.AreEqual("Mp3",AnswerAux);
        }

        [Test]
        public void ConvertMp3ToWma()
        {
            TrackConvert = Interfaz.ConvertSound("Wma", AerosmithTrack1);
            Assert.AreEqual("Wma", TrackConvert.ReturnTypeOfSound());
        }
        [Test]
        public void ConvertMp3ToMp3()
        {
            TrackConvert = Interfaz.ConvertSound("Mp3", AerosmithTrack1);
            Assert.AreEqual("Mp3", TrackConvert.ReturnTypeOfSound());
        }
        [Test]
        public void ConvertAviToMp4()
        {
            VideoConverter = Interfaz.VideoConvert("Mp4", IpmanMovie1);
            AnswerAux = "Mp4";
            Assert.AreEqual(AnswerAux, VideoConverter.ReturnTypeOfVideo());
        }
        [Test]
        public void ConvertAviToAvi()
        {
            VideoConverter = Interfaz.VideoConvert("Avi", IpmanMovie1);
            AnswerAux = "Avi";
            Assert.AreEqual(AnswerAux, VideoConverter.ReturnTypeOfVideo());
        }   
        [Test]
        public void ConvertAviToMp4WithSound()
        {
            VideoConverter = Interfaz.VideoConvert("Mp4", IpmanMovie1);
            AnswerAux = "Formato del video: Mp4, Formato del sonido: Wma";
            Assert.AreEqual(AnswerAux, VideoConverter.ReturnTypeOfVideoAndSound());
        }
        [Test]
        public void ConvertAviToAviWithSound()
        {
            VideoConverter = Interfaz.VideoConvert("Avi", IpmanMovie1);
            AnswerAux = "Formato del video: Avi, Formato del sonido: Wma";
            Assert.AreEqual(AnswerAux, VideoConverter.ReturnTypeOfVideoAndSound());
        }
        [Test]
        public void AssignamentNewDetails()
        {
            AerosmithTrack1.AssignamentToDetails(450,"Fly Away From Here");
            Assert.AreNotEqual("Dream", AerosmithTrack1.Title);
        }
        [Test]
        public void ExtractSoundToAnyVideo()
        {
            TrackConvert = IpmanMovie1.ExtractSound();
            AnswerAux = "El titulo es: Ip Man , Duraccion es: 15500, El formato del audio es: Wma";
            Assert.AreEqual(AnswerAux,TrackConvert.AboutTrack());
        }
    }
}