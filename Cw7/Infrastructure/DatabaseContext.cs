using Microsoft.EntityFrameworkCore;
namespace Cw7.Infrastructure;

public class DatabaseContext(DbContextOptions opt) : DbContext(opt)
{
    
}