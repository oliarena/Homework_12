namespace Task_3
{
    class TimerModel
    {
        private int _time;

        public string Tick()
        {
            _time++;
            int min = _time / 60;
            int sec = _time % 60;
            return String.Format($"{min} : {sec}");
        }

        public void Reset()
        {
            _time = 0;
        }
    }
}
