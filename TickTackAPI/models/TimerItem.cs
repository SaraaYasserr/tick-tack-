namespace TickTackAPI.models
{
    public class TimerItem
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public bool IsRunning{ get; set; }
    }
}
