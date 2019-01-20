namespace Pluralsight.DesignPatterns.Factory
{
    public class Settings
    {
        private Settings()
        { }

        public string FactoryName { get; set; } = "Pluralsight.DesignPatterns.Factory.MiniCooperFactory";
        public string AbstractFactoryName { get; set; } = "Pluralsight.DesignPatterns.Factory.MiniCooperFactory";

        public static Settings Instance { get; } = new Settings();
    }
}
