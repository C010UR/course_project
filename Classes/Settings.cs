using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CourseProject.Classes
{
    internal class Settings
    {
        public static NpgsqlConnectionStringBuilder conStr = new NpgsqlConnectionStringBuilder();

    }
}
