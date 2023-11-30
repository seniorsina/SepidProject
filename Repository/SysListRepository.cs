using Contracts;
using DataContext;
using Models.Modle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository;
public class SysListRepository : RepositoryBase<SysList>, ISysListRepository
{

    public SysListRepository(TeamDbContext dbContext) : base(dbContext)
    {
    }
    public IEnumerable<SysList> GetSysListByFlag(int fl)
    {
        var list = FindByCondition(sl => sl.Fl == fl, false).ToList();
        return list;    
    }
}
