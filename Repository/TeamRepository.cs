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



    public bool AddTeam(Team team)
    {
        try
        {
            Add(team);
            Save();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public IEnumerable<Team> GetAllTeam(bool trackChanges)
    {
        return FindAll(trackChanges).OrderBy(t => t.Name).ToList();
    }

    public Team GetTeam(int id)
    {
        Team team = FindByCondition(t => t.Id == id, false).FirstOrDefault();
        return team;
    }

    public bool RemoveATeam(int id)
    {
        try
        {
            Team team = FindByCondition(t => t.Id == id, false).FirstOrDefault();
            if (team != null)
            {
                Remove(team);
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

    public bool UpdateATeam(Team team)
    {
        try
        {
            Update(team);
            Save();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}
