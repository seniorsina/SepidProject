using Contracts;
using DataContext;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository;
public class TeamRepository : RepositoryBase<Team>, ITeamRepository
{
    public TeamRepository(TeamDbContext dbContext) : base(dbContext)
    {
    }
    public IEnumerable<Team> GetAllTeam(bool trackChanges)
    {
        return FindAll(trackChanges).OrderBy(t => t.Name).ToList();
    }
}
