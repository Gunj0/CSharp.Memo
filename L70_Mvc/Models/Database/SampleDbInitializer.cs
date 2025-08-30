using L70_Mvc.Models.Entities;

namespace L70_Mvc.Models.Database;

/// <summary>
/// DB初期化クラス
/// </summary>
public class SampleDbInitializer(SampleDbContext dbContext)
{
    /// <summary>
    /// DBコンテキスト
    /// </summary>
    private readonly SampleDbContext _dbContext = dbContext;

    /// <summary>
    /// 初期化処理
    /// </summary>
    public void Run()
    {
        _dbContext.Books.AddRange(
            new Book { Title = "C#入門", Price = 2500 },
            new Book { Title = "Java入門", Price = 2300 },
            new Book { Title = "Python入門", Price = 2700 }
        );
        _dbContext.SaveChanges();
    }
}
