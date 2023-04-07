using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Advanced_Topics_in_C_Sharp_Lab05.Models;

namespace Advanced_Topics_in_C_Sharp_Lab05.Data
{
    public class Advanced_Topics_in_C_Sharp_Lab05Context : DbContext
    {
        public Advanced_Topics_in_C_Sharp_Lab05Context (DbContextOptions<Advanced_Topics_in_C_Sharp_Lab05Context> options)
            : base(options)
        {
        }

        public DbSet<Advanced_Topics_in_C_Sharp_Lab05.Models.BankAccount> BankAccount { get; set; } = default!;
    }
}
