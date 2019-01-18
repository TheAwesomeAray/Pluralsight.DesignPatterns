using System.Collections.Generic;

namespace Pluralsight.DesignPatterns.Domain
{
    public interface IDataPatternRendererAdapter
    {
        string ListPatterns(IEnumerable<Pattern> patterns);
    }
}