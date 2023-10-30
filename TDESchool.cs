namespace TODO
{
    public enum TDDayofWeek
    {
        Sunday = 0, Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6
    }
    public class TDESchool : TDEvent
    {
        //attributes
        private string _course_name;
        private string _course_id;
        private bool _online;
        private List<TDDayofWeek> _meeting_days;

        //constructors
        public TDESchool() : base()
        {
            _course_name = "Unknown";
            _course_id = "ABC-123";
            _online = false;

        }
    }
}
