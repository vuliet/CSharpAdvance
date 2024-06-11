using System.Collections.Generic;

public class DummyData
{
    public static Character Character() => new Character
    {
        CharacterID = 4,
        CharacterName = "VKCT",
        CharacterAge = 25
    };

    public static Character Character2() => new Character
    {
        CharacterID = 43,
        CharacterName = "VKCsT",
        CharacterAge = 25
    };

    public static Character Character3()
    {
        return new Character() 
        {
            CharacterID = 43,
            CharacterName = "VKCsT",
            CharacterAge = 25
        };
    }
}

