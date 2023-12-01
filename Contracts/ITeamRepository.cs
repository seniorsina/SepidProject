using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts;
public interface ITeamRepository
{
    IEnumerable<Team> GetAllTeam(bool trackChanges);
    bool AddTeam(Team team);
    bool UpdateATeam(Team team);
    Team GetTeam(int id);
    bool RemoveATeam(int id);

}
