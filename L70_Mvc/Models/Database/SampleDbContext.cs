using L70_Mvc.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace L70_Mvc.Models.Database;

public class SampleDbContext : DbContext
{
  /// <summary>
  /// コンストラクタ
  /// </summary>
  /// <param name="options">DbContextオプション</param>
  public SampleDbContext(DbContextOptions<SampleDbContext> options)
    : base(options)
  {
  }

  public DbSet<Book> Books { get; set; }
}
