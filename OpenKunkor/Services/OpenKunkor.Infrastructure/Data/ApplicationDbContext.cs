using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OpenKunkor.Infrastructure.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.Marshalling;
using OpenKunkor.Domain.Entities;
using OpenKunkor.Domain.Join;

namespace OpenKunkor.Infrastructure.Data
{
    class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option)
        {
            
        }
        public DbSet<Answer> answers { get; set; }
        public DbSet<Chat> chats { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Content> contents { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Question> questions { get; set; }
        public DbSet<UserContentLike> userContentLikes { get; set; }
        public DbSet<UserChat> userChats { get; set; }
        public DbSet<UserFollow> userFollows { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
