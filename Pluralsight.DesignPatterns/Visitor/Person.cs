using System.Collections.Generic;

namespace Pluralsight.DesignPatterns.Visitor
{
    class Person : IAsset
    {
        public IEnumerable<IAsset> Assets { get; set; }

        public void Accept(IVisitor visitor)
        {
            foreach (var asset in Assets)
                asset.Accept(visitor);
        }
    }
}
