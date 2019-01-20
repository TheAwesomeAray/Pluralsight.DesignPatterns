using System;
using System.Collections.Generic;
using System.Reflection;

namespace Pluralsight.DesignPatterns.Factory
{
    class SimpleFactory
    {
        Dictionary<string, Type> autos;

        public SimpleFactory()
        {
            LoadCarTypes();
        }

        public IAuto CreateInstance(string carName)
        {
            Type t = GetTypeToCreate(carName);
            if (t == null)
                return new NullCar();

            return Activator.CreateInstance(t) as IAuto;
        }

        private Type GetTypeToCreate(string carName)
        {
            Type t;
            autos.TryGetValue(carName, out t);
            return t;
        }

        private void LoadCarTypes()
        {
            autos = new Dictionary<string, Type>();
            Type[] typesInAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in typesInAssembly)
            {
                if (type.GetInterface(typeof(IAuto).ToString()) != null)
                    autos.Add(type.Name, type);
            }
        }
    }
}
