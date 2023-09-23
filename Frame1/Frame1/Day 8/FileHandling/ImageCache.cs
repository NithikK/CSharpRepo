using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frame1.Day_8
{
    public class ImageCache
    {
        public static byte[] Logo
        {
            get
            {
                byte[] _logoBytes = null;
                if(_logoBytes == null){
                    _logoBytes = File.ReadAllBytes(@"C:\Users\nithik.k\source\Traning Phase\Frame1\Frame1\Day 8\FileHandling\Html_Logo.png");
                }
                return _logoBytes;
            }
        }
    }
}