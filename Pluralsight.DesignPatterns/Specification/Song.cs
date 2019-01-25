using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Specification
{
    class Song
    {
        public string Title { get; set; }
        public int Rating { get; set; }
        public Genre Genre { get; set; }
        public Artist Artist { get; set; }
    }
}
