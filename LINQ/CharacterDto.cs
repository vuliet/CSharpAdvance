using System.Collections.Generic;
using static DummyData;

public class Character
{
    public int CharacterID { get; set; }
    public string CharacterName { get; set; }
    public int CharacterAge { get; set; }
    public List<Job> ListJob { get; set; }
}