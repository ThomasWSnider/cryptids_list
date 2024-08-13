namespace cryptids_list.Services;

public class CryptidsService
{
  private readonly CryptidsRepository _cryptidsRepository;

  public CryptidsService(CryptidsRepository cryptidsRepository)
  {
    _cryptidsRepository = cryptidsRepository;
  }
  public List<Cryptid> GetAllCryptids()
  {
    List<Cryptid> cryptids = _cryptidsRepository.GetAllCryptids();
    return cryptids;
  }
}