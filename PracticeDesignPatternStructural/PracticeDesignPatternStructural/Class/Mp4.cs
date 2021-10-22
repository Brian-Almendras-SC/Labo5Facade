using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDesignPatternStructural.Class
{
    public class Mp4:Video
    {
        public Mp4()
        {
            TypeVideo = "Mp4";
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
            Avi Anwers;
            Anwers = new Avi();
            Anwers.Title = video.Title;
            Anwers.TimeInSeconds = video.TimeInSeconds;
            Anwers.TypeSound = video.TypeSound;
            return Anwers;
        }
        public override Mp4 ConvertToMp4(Video video)
        {
            return video as Mp4;
        }
    }
}
