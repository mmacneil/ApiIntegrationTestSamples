using System;
using Web.Api.Core.Domain.Entities;
using Web.Api.Infrastructure.Data;

namespace Web.Api.IntegrationTests
{
    public static class SeedData
    {
        public static void PopulateTestData(AppDbContext dbContext)
        {
            dbContext.Players.Add(new Player("Wayne", "Gretzky", 183, 84, new DateTime(1961,1,26)) { Id = 1, Created = DateTime.UtcNow });
            dbContext.Players.Add(new Player("Mario", "Lemieux", 193, 91, new DateTime(1965, 11, 5)) { Id = 2, Created = DateTime.UtcNow });
            dbContext.SaveChanges();
        }
    }
}
 