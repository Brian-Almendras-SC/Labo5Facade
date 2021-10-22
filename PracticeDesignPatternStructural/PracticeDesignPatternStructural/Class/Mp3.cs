using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDesignPatternStructural.Class
{
    public class Mp3: Sound
    {
        public Mp3() {
            TypeSound = "Mp3";
        }   
        public Mp3(int Time, string Title)
        {
            TypeSound = "Mp3";
            AssignamentToDetails(Time,Title);
        }
        public override string ReturnTypeOfSound()
        {
            return TypeSound;
        }
        public override Wma ConvertToWma(Sound Track)
        {
            Wma Anwers;
            Anwers = new Wma();
            Anwers.Title = Track.Title;
            Anwers.TimeInSeconds = Track.TimeInSeconds;
            return Anwers;
        }
        public override Mp3 ConvertToMp3(Sound Track)
        {
            return Track as Mp3;
        }
    }
}
