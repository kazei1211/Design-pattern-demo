using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayVlc(string fileName)
        {
            // Do nothing
        }

        public void PlayMp4(string fileName)
        {
            Console.WriteLine($"Playing mp4 file. Name: {fileName}");
        }
    }
}
