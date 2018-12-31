using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WantList.Domain.Abstract;
using WantList.Domain.Objects;

namespace WantList.Infrastructure.Data
{
    public class WantListContext : DbContext
    {
        public WantListContext()
        { }

        public DbSet<Category> Categories{ get; set; }
        public DbSet<Item> Items{ get; set; }
    }
}