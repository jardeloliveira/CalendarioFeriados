using System;

namespace CalendarioFeriados.Models
{
    public class Events:Event
    {
    }

    public class Location:Event
    {
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
    }

    public class Event
    {
        public string date { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string type_code { get; set; }
        public string link { get; set; }
    }
}
