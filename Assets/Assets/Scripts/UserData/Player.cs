using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VR_RPG
{
    public class Player
    {
        public string Username { private set; get; }
        public ICollection<Soul> Souls { private set; get; }
        public DateTime AccountCreated { get; private set; }


        public Player(string username)
        {
            Username = username;
            Souls = new List<Soul>();
            AccountCreated = DateTime.Now;
        }

        public void AddSoul(Soul soul)
        {
            Souls.Add(soul);
        }
    }
}
