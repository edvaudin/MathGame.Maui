using edVaudin.MathGame.Maui.Models;
using SQLite;
namespace edVaudin.MathGame.Maui.Data;

public class GameRepository
{
    readonly string dbPath;
    private SQLiteConnection conn;

    public GameRepository(string dbPath)
    {
        this.dbPath = dbPath;
    }

    public void Init()
    {
        conn = new(dbPath);
        conn.CreateTable<Game>();
    }

    public List<Game> GetAllGames()
    {
        Init();
        return conn.Table<Game>().ToList();
    }

    public void Add(Game game)
    {
        conn = new(dbPath);
        conn.Insert(game);
    }

    public void Delete(int id)
    {
        conn = new(dbPath);
        conn.Delete(new Game{ Id = id });
    }
}
