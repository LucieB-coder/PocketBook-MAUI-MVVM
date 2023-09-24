using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Stub;

namespace PocketBook
{
    public partial class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ILibraryManager,Stub.Stub>();
        }
    }
}
