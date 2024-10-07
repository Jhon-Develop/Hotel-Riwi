using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Riwi.DataBase
{
    public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
    {
        
    }
}