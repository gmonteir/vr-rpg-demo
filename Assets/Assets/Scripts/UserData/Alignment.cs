using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VR_RPG
{
    public class Alignment
    {
        #region default alignments
        public static readonly Alignment LawfulGood = new Alignment(150, 150);
        public static readonly Alignment NeutralGood = new Alignment(0, 150);
        public static readonly Alignment ChaoticGood = new Alignment(-150, 150);
        public static readonly Alignment LawfulNeutral = new Alignment(150, 0);
        public static readonly Alignment TrueNeutral = new Alignment(0, 0);
        public static readonly Alignment ChaoticNeutral = new Alignment(-150, 0);
        public static readonly Alignment LawfulEvil = new Alignment(150, 150);
        public static readonly Alignment NeutralEvil = new Alignment(0, 150);
        public static readonly Alignment ChaoticEvil = new Alignment(-150, 150);

        #endregion

        public float EvilOrGood { get; set; }
        public float ChaosOrLaw { get; set; }

        public Alignment()
        {
            new Alignment(TrueNeutral);
        }
        private Alignment(float evilOrGood, float chaosOrLaw)
        {
            EvilOrGood = evilOrGood;
            ChaosOrLaw = chaosOrLaw;
        }

        public Alignment(Alignment alignment)
        {
            EvilOrGood = alignment.EvilOrGood;
            ChaosOrLaw = alignment.ChaosOrLaw;
        }
    }
}
