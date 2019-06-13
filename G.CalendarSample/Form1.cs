using System;
using System.Windows.Forms;
using G.Calendar.Classes;

namespace G.CalendarSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var ce = new CustomEvent
            {
                IgnoreTimeComponent = true,
                EventText = "Eat! Sleep! Code!",
                EventDetails = new { Welcome = "Hello" },
                Date = DateTime.Now,
                RecurringFrequency = RecurringFrequencies.None,
                Enabled = true
            };
            calendar1.AddEvent(ce);

            var he = new HolidayEvent
            {
                IgnoreTimeComponent = true,
                EventText = "Codes Day!",
                EventDetails = new { Hello = "World" },
                Date = DateTime.Now,
                RecurringFrequency = RecurringFrequencies.None,
                Enabled = true
            };
            calendar1.AddEvent(he);
        }
    }
}
