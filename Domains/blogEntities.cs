using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rockcodeafrica.Domains
{
    public class blogEntities:DbContext
    {
        public blogEntities(DbContextOptions options) : base(options: options)
        {
        }
    }
}
