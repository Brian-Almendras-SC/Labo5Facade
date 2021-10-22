using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDesignPatternStructural.Class
{
    public class ConvertVideo
    {
        public Video VideoConvert(string Option,Video File) 
        {
            switch (Option)
            {
                case "Mp4":
                    return File.ConvertToMp4(File);
                case "Avi":
                    return File.ConvertToAvi(File);
                default: throw new NotImplementedException();
            }
        }
        public Sound ConvertSound(string Option,Sound File)
        {
            switch (Option)
            {
                case "Mp3":
                    return File.ConvertToMp3(File);
                case "Wma":
                    return File.ConvertToWma(File);
                default: throw new NotImplementedException(); 
            }
        }
        public Sound ExtractSoundtrack(string Option, Video Video)
        {
            switch (Option)
            {
                case "Extract":return Video.ExtractSound();
                default: throw new NotImplementedException();

            }
        }

    }
}
