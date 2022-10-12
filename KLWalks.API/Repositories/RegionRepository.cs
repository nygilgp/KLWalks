using System;
using KLWalks.API.Data;
using KLWalks.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace KLWalks.API.Repositories
{
    public class RegionRepository: IRegionRepository
    {
        private readonly KLWalksDBContext kLWalksDBContext;

        public RegionRepository(KLWalksDBContext kLWalksDBContext)
        {
            this.kLWalksDBContext = kLWalksDBContext;
        }

        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await kLWalksDBContext.Regions.ToListAsync();
            //throw new NotImplementedException();
        }
    }
}

