namespace cryptids_list.Repositories
{

  public class CryptidsRepository
  {
    private readonly IDbConnection _db;

    public CryptidsRepository(IDbConnection db)
    {
      _db = db;
    }

    public List<Cryptid> GetAllCryptids()
    {
      string sql = "SELECT * FROM cryptids;";

      List<Cryptid> cryptids = _db.Query<Cryptid>(sql).ToList();
      return cryptids;
    }
  }
}