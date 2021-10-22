using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDesignPatternStructural.Class
{
    public class Avi: Video
    {
        public Avi()
        {
            TypeVideo = "Avi";
        }
        public override string ReturnTypeOfVideo()
        {
            return base.TypeVideo;
        }
        public override string ReturnTypeOfVideoAndSound()
        {
            return $"Formato del video: {base.TypeVideo}, Formato del sonido: {TypeSound.ReturnTypeOfSound()}";
        }
        public override Avi ConvertToAvi(Video video)
        {
            return video as Avi;
        }
        public override Mp4 ConvertToMp4(Video video)
        {
            Mp4 Anwers;
            Anwers = new Mp4();
            Anwers.Title = video.Title;
            Anwers.TimeInSeconds = video.TimeInSeconds;
            Anwers.TypeSound = video.TypeSound;
            return Anwers;
        }
    }
}
