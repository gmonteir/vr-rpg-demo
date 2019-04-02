using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VR_RPG
{
    public class Race
    {
        #region default races

        #region humanoid races
        public static readonly Race HUMAN = new Race("Human", true);
        public static readonly Race HALF_ELF = new Race("Half elf", true);
        #endregion

        #region non-humanoid races
        #endregion

        public static IEnumerable<Race> Values
        {
            get
            {
                yield return HUMAN;
                yield return HALF_ELF;
            }
        }
        #endregion

        public string RaceName { get; private set; }
        public bool Humanoid { get; private set; }

        Race(string raceName, bool humanoid)
        {
            RaceName = raceName;
            Humanoid = humanoid;
        }

        public override string ToString()
        {
            return RaceName;
        }

        public override bool Equals(object obj)
        {
            return ToString().Equals(obj.ToString());
        }
    }
}
