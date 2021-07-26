using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Mealy_BT.Models
{
    public class MealyContext:DbContext
    {
        public MealyContext(DbContextOptions<MealyContext> options) : base(options)
        {
        }
        
        public DbSet<Task> Tasks { get; set; }
    }
}