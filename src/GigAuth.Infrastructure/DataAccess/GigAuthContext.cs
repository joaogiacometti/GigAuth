using GigAuth.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GigAuth.Infrastructure.DataAccess;

public class GigAuthContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<User> Users { get; init; }
    public DbSet<Role> Roles { get; init; }
    public DbSet<ForgotPasswordToken> ForgotPasswordTokens { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; init; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(GigAuthContext).Assembly);
    }
}