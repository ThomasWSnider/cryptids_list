namespace cryptids_list.Models;

public class Cryptid
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Location { get; set; }
  public bool eatsPeople { get; set; }
  public bool isHumanoid { get; set; }
}