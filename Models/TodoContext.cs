using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    // Adicionando contexto de banco de dados
    public class TodoContext : DbContext
    {
        // DbContextOptions : fornece opções... configurações do banco.
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        // DbSeT : possibilidades de manusear as tabelas do banco.
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
