using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frame1.Day_3
{
    public class MediaContent
    {
        public virtual void StartPlayingContent(){
            System.Console.WriteLine("Start");
        }
        public virtual void StopPlayingContent(){
            System.Console.WriteLine("Stop");
        }
        public void PausePlayingContent(){
            System.Console.WriteLine("Pause");
        }
        public void ContinuePlayingContent(){
            System.Console.WriteLine("Continue");
        }
    }
    internal class AudioContent : MediaContent{
        //cannot override parent method by default
        //only virtual method from parent can be overridden
        //to prevent further overrides add sealed to it
        public override sealed void StartPlayingContent(){
            System.Console.WriteLine("Start from AudioContent");
        }
    }
    internal class VideoContent : AudioContent{
        /*
        public override void StartPlayingContent(){
            System.Console.WriteLine("Start from VideoContent");
        }
        */
    }
    internal class MediaTester{
        public static void TestOne(){
            System.Console.WriteLine("");
        }
    }
}