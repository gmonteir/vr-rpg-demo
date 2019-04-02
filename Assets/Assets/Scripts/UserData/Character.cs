using System;

namespace VR_RPG
{
    public class Character
    {
        public short Id { get; private set; }
        public short Level { private set; get; }
        public float Experience { private set; get; }

        public string CharName { private set; get; }
        public Alignment CharAlignment { get; private set; }
        public Race CharRace { get; private set; }
        public DateTime Created { get; private set; }

        public Character() : this(0, "Default", Race.HUMAN, Alignment.TrueNeutral) { }

        public Character(short id,  string name, Race race, Alignment alignment)
        {
            Id = id;
            Level = 0;
            Experience = 0;
            CharName = name;
            CharAlignment = alignment;
            CharRace = race;
            Created = DateTime.Now;
        }

        public void SetName(string name)
        {
            //TODO: check name input
            CharName = name;
        }

        public void SetRace(Race race)
        {
            //TODO: check race input
            CharRace = race;
        }
    }
}