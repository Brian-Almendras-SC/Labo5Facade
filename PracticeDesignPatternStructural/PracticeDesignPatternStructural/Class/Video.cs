using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDesignPatternStructural.Class
{
    public abstract class Video
    {
        public string TypeVideo { set; get; }
        public int TimeInSeconds { set; get; }
        public string Title { set; get; }
        public Sound TypeSound;
        public void AssignamentToDetails(int Time, string Tittle,Sound Sound)
        {
            TypeSound = Sound;
            TimeInSeconds = Time;
            this.Title = Title;
            TypeSound.AssignamentToDetails(Time, Tittle);
        }
        public abstract string ReturnTypeOfVideo();
        public abstract string ReturnTypeOfVideoAndSound();
        public abstract Mp4 ConvertToMp4(Video video);
        public abstract Avi ConvertToAvi(Video video);
        public string AboutVideo()
        {
            return $"El titulo es: {Title}, Duraccion es: {TimeInSeconds}, El formato del video es: {TypeVideo}. {TypeSound.AboutTrack()} ";
        }
        public Sound ExtractSound()
        {
            return TypeSound;
        }
    }
}
