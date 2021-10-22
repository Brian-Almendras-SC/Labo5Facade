using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDesignPatternStructural.Class
{
    public class Wma: Sound
    {
        public Wma()
        {
            TypeSound = "Wma";
        }
        public Wma(int Time, string Title)
        {
            TypeSound = "Wma";
            AssignamentToDetails(Time, Title);
        }

        public override string ReturnTypeOfSound()
        {
            return TypeSound;
        }
        public override Wma ConvertToWma(Sound Track)
        {
            throw new NotImplementedException();
        }
        public override Mp3 ConvertToMp3(Sound Track)
        {
            Mp3 Anwers;
            Anwers = new Mp3();
            Anwers.Title = Track.Title;
            Anwers.TimeInSeconds = Track.TimeInSeconds;
            return Anwers;
        }
    }
}
