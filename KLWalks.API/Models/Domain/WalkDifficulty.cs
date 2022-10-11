using System;
namespace KLWalks.API.Models.Domain
{
    public class WalkDifficulty
    {
        public Guid Id { get; set; }
        public string Code { get; set; }

        // Navigation properties

        public IEnumerable<Walk> Walks { get; set; }
    }
}

