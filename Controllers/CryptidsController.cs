namespace cryptids_list.Controllers;

[ApiController]
[Route("api/cryptids")]
public class CryptidsController : ControllerBase
{
  private readonly CryptidsService _cryptidsService;

  public CryptidsController(CryptidsService cryptidsService)
  {
    _cryptidsService = cryptidsService;
  }

  [HttpGet]
  public ActionResult<List<Cryptid>> GetAllCryptids()
  {
    try
    {
      List<Cryptid> cryptids = _cryptidsService.GetAllCryptids();
      return Ok(cryptids);
    }
    catch (Exception exception)
    {
      return BadRequest(exception.Message);
    }
  }
}