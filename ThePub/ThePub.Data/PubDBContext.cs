using Microsoft.EntityFrameworkCore;
using System;

namespace ThePub.Data
{
    public class PubDBContext : DbContext
    {
        public PubDBContext(DbContextOptions<PubDBContext> options) 
            : base(options)
        {
        }


    }
}
