using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts;
public  interface IPlayerRepository
{
    IEnumerable<Player> GetAllPlayer(bool trackChanges);
    IEnumerable<Player> GetTeamPlayers(int teamId, bool trackChanges);
    bool AddPlayer(Player player);
    bool UpdateAPlayer(Player player);
    Player GetPlayer(int id);
    bool RemoveAPlayer(int id);


}
