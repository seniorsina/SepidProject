using Contracts;
using DataContext;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository;
public class PlayerRepository : RepositoryBase<Player>, IPlayerRepository
{
    public PlayerRepository(TeamDbContext dbContext) : base(dbContext)
    {
    }
    public bool AddPlayer(Player player)
    {
        try
        {
            Add(player);
            Save();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public IEnumerable<Player> GetAllPlayer(bool trackChanges)
    {
        return FindAll(trackChanges).OrderBy(p => p.Name).ToList();
    }

    public Player GetPlayer(int id)
    {
        Player p = FindByCondition(t => t.Id == id, false).FirstOrDefault();
        return p;
    }

    public IEnumerable<Player> GetTeamPlayers(int teamId, bool trackChanges)
    {
        return FindByCondition(p => p.TeamId == teamId, false).ToList();
    }

    public bool RemoveAPlayer(int id)
    {
        try
        {
            Player player = FindByCondition(t => t.Id == id, false).FirstOrDefault();
            if (player != null)
            {
                Remove(player);
                Save();
                return true;
            }
            else
            {
                return false;
            }
        }
        catch
        {
            return false;
        }
    }

    public bool UpdateAPlayer(Player player)
    {
        try
        {
            Update(player);
            Save();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}
