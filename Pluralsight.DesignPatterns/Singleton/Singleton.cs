using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Singleton
{
    public class Singleton
    {
        // Not thread safe!!!!!
        private static Singleton _instance;

        private Singleton()
        { }
        
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();

                return _instance;
            }
        }
    }
}
