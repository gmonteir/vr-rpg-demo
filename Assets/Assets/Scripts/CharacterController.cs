using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VR_RPG
{
    public class CharacterController : MonoBehaviour
    {
        Character NewChar;

        // Use this for initialization
        void Start()
        {
            NewChar = new Character();
        }

        // Update is called once per frame
        /*void Update () {

        }*/

        public void SetName(string name)
        {
            NewChar.SetName(name);
        }
    }
}
