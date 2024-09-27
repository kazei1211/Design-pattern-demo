using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class FlacPlayer
    {
        private readonly IAudioService _audioService;

        public FlacPlayer(IAudioService audioService)
        {
            _audioService = audioService;
        }

        public string PlayFlac()
        {
            return _audioService.ProcessAudio("Playing FLAC format audio");
        }
    }
}
