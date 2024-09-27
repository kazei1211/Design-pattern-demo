using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class FlacToMp3Adapter : IMediaPlayer
    {
        private readonly FlacPlayer _flacPlayer;

        public FlacToMp3Adapter(FlacPlayer flacPlayer)
        {
            _flacPlayer = flacPlayer;
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("flac", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Adapter with DI: {_flacPlayer.PlayFlac()}");
            }
            else
            {
                Console.WriteLine($"Invalid media. {audioType} format not supported");
            }
        }
    }
}
