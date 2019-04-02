using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VR_RPG;

public class Soul {
    public ICollection<Character> Characters { get; private set; }
    public Character CurrentCharacter { get; private set; }

    public Soul()
    {
        Characters = new List<Character>();
    }

    public void AddCharacter(Character character)
    {
        CurrentCharacter = character;
        Characters.Add(character);
    }
}
