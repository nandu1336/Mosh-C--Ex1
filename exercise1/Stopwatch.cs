using System;

namespace Inter_Ex2
{
    public class Stopwatch
    {
        private Boolean _isStart;
        private DateTime _startTime;
        private DateTime _stopTime;
        private TimeSpan _timeSpan;

        public void Start()
        {
            if (_isStart)
            {
                throw new InvalidOperationException();
            }

            _startTime = DateTime.Now;
            _isStart = true;

        }

        public string Stop()
        {
            if (!_isStart)
            {
                throw new InvalidOperationException();
            }
            _stopTime = DateTime.Now;
            _timeSpan = _stopTime - _startTime;
            _isStart = false;

            return _timeSpan.Seconds.ToString();
        }
    }
}



    