using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Interfaces.Gateways.Repositories;

namespace Web.Api.Infrastructure.Data.Repositories
{
    internal sealed class PlayerRepository : EfRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
