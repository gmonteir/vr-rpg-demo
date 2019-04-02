using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace VR_RPG
{
    public class SceneController : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void MainMenu()
        {
            SceneManager.LoadScene("MainMenu");
        }
        public void CharacterCreation()
        {
            SceneManager.LoadScene("CharacterCreation");
        }
    }
}
