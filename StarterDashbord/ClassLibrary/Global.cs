using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterDashbord.ClassLibrary;
internal class Global
{
    public static ApiClient ApiClient = new ApiClient(Properties.Settings.Default.RootUrl);
}
