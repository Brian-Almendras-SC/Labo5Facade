using PracticeDesignPatternStructural.Class;
using System;

namespace PracticeDesignPatternStructural
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertVideo Interfaz = new ConvertVideo();
            Sound AerosmithTrack1 = new Mp3();
            Sound TrackConvert;
            Video IpmanMovie1 = new Avi();
            Video VideoConverter;

            AerosmithTrack1.AssignamentToDetails(330,"Dream");
            IpmanMovie1.AssignamentToDetails(15500,"Ip Man ",new Wma());


            Console.WriteLine(AerosmithTrack1.AboutTrack());
            TrackConvert = Interfaz.ConvertSound("Mp3",AerosmithTrack1);
            Console.WriteLine(TrackConvert.AboutTrack());

            Console.WriteLine(IpmanMovie1.AboutVideo());
            VideoConverter = Interfaz.VideoConvert("Mp4", IpmanMovie1);
            Console.WriteLine(VideoConverter.AboutVideo());
        }
    }
}
