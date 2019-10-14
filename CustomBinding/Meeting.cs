using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CustomBinding
{
    /// <summary>   
    /// Represents custom data properties.   
    /// </summary>   
    public class Meeting
    {
        public string EventName { get; set; }
        public string Organizer { get; set; }
        public string ContactID { get; set; }
        public int Capacity { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Brush Color { get; set; }
        public bool AllDay { get; set; }
    }
}
