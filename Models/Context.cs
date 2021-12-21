﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaCrud.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context>options) : base(options)
        {

        }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Reserva> reserva { get; set; }

    }
}
