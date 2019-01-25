using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Specification
{
    class Album
    {
        public IEnumerable<Song> Songs { get; set; }
        public int Year { get; set; }
    }
}
