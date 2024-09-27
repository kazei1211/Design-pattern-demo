using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class MediaAdapter : IMediaPlayer
    {
        IAdvancedMediaPlayer advancedMusicPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
            {
                advancedMusicPlayer = new VlcPlayer();
            }
            else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                advancedMusicPlayer = new Mp4Player();
            }
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
            {
                advancedMusicPlayer.PlayVlc(fileName);
            }
            else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                advancedMusicPlayer.PlayMp4(fileName);
            }
        }
    }
}
