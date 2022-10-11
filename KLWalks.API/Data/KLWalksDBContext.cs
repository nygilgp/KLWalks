using System;
using KLWalks.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace KLWalks.API.Data
{
    public class KLWalksDBContext: DbContext
    {
        public KLWalksDBContext(DbContextOptions<KLWalksDBContext> options): base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulties { get; set; }
    }
}

