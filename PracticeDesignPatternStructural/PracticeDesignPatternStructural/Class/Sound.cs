using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDesignPatternStructural.Class
{
    public abstract class Sound
    {
        public string TypeSound { set; get; }
        public int TimeInSeconds { set; get; }
        public string Title { set; get; }
        public void AssignamentToDetails(int Time,string Title) 
        { 
            TimeInSeconds = Time;
            this.Title = Title;
        }
        public abstract string ReturnTypeOfSound();
        public abstract Mp3 ConvertToMp3(Sound Track);
        public abstract Wma ConvertToWma(Sound Track);
        public string AboutTrack()
        {
            return $"El titulo es: {Title}, Duraccion es: {TimeInSeconds}, El formato del audio es: {TypeSound}";
        }

    }
}
