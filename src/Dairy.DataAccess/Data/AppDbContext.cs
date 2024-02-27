using Microsoft.EntityFrameworkCore;

namespace Dairy.DataAccess.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
}