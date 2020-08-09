using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace AlarmProgram
{
    public class AudioManager
    {
        private WaveOut m_WaveOut;
        
        public AudioManager()
        {
            m_WaveOut = new WaveOut();
            m_WaveOut.PlaybackStopped += Music_PlaybackStopped;
        }

        public void Initialize(string path)
        {
            var reader = new Mp3FileReader(path);
            m_WaveOut.Init(reader);
        }

        public void Play()
        {
            m_WaveOut.Play();
        }

        public void Stop()
        {
            m_WaveOut.Stop();
        }

        public void Pause()
        {
            m_WaveOut.Pause();
        }

        public void Resume()
        {
            m_WaveOut.Resume();
        }

        public void Dispose()
        {
            m_WaveOut.Dispose();
        }

        public bool NowPlaying()
        {
            if (m_WaveOut.PlaybackState == PlaybackState.Playing) return true;
            else return false;
        }

        private void Music_PlaybackStopped(object sender, EventArgs e)
        {
            m_WaveOut.Stop();
        }
    }
}
