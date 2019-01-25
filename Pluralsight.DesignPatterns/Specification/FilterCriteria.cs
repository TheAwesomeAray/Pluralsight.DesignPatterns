using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace Pluralsight.DesignPatterns.Specification
{
    class FilterCriteria
    {
        public List<int> IncludedGenres { get; set; }
        public List<int> IncludedArtists { get; set; }
        public List<int> AlbumsToInclude { get; set; }
        public string TitleFilter { get; set; }
        public int MinimumRating { get; set; } = 0;

        public Expression<Func<Song, bool>> Criteria
        {
            get
            {
                return s => (!IncludedArtists.Any() || IncludedArtists.Contains(s.Artist.Id)) &&
                            (!IncludedGenres.Any() || IncludedGenres.Contains(s.Genre.Id)) &&
                            (!string.IsNullOrEmpty(TitleFilter) || s.Title.Contains(TitleFilter)) &&
                            s.Rating > MinimumRating;
                            
            }
        }

    }
}
