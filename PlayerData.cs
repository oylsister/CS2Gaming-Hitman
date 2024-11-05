namespace Hitman
{
    public class PlayerKillCount
    {
        public PlayerKillCount(int kill = 0, bool complete = false)
        {
            _killCount = kill;
            _complete = complete;
        }

        private int _killCount;
        private bool _complete;

        public int KillCount
        {
            get { return _killCount; }
            set { _killCount = value; }
        }

        public bool Complete
        {
            get { return _complete; }
            set { _complete = value; }
        }
    }

    public class PlayerData : PlayerKillCount
    {
        public PlayerData(string achieve, string reset, int count, bool complete = true)
        {
            _timeAcheived = achieve;
            _timeReset = reset;

            KillCount = count;
            Complete = complete;
        }

        private string _timeAcheived;
        private string _timeReset;

        public string TimeAcheived
        {
            get { return _timeAcheived; }
            set { _timeAcheived = value; }
        }

        public string TimeReset
        {
            get { return _timeReset; }
            set { _timeReset = value; }
        }
    }
}
