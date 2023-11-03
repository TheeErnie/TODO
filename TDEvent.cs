namespace TODO
{
    public class TDEvent
    {
        //attributes
        private DateTime _start_time;
        private DateTime _end_time;
        private string _name;
        private bool _completed;

        //constructor
        public TDEvent()
        {
            _start_time = DateTime.Today; 
            _end_time = DateTime.Today;
            _name = "NO_NAME_GIVEN";
            _completed = false;
        }

        public TDEvent(DateTime start_time, DateTime end_time, string name)
        {
            _start_time=start_time;
            _end_time=end_time;
            _name=name;
            _completed = false;
        }

        //properties
        public string StartTimeString
        {
            get { return _start_time.ToString("h:mm tt"); }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //methods
        public void UpdateAvailability()
        {

        }

        public void NotifyUser()
        {

        }

        public void VerifyEventCompletion()
        {
            bool ui = false;
            //userinput
            _completed = ui;
        }
    }
}
