using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rockcodeafrica.Domains
{
    public class rockWebEntities:DbContext
    {
        public rockWebEntities(DbContextOptions options) : base(options: options)
        {
        }
    }
}
