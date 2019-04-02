using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace VR_RPG
{
    public class MainMenuController : MonoBehaviour
    {
        [SerializeField]
        private GameObject CharListArea;
        [SerializeField]
        private GameObject CharSelectPrefab;
        private ICollection<Character> Characters;
        private ICollection<GameObject> CharSelects;

        // Use this for initialization
        void Start()
        {
            //Initialize collections
            Characters = new List<Character>();
            CharSelects = new List<GameObject>();

            //disable the prefab
            CharSelectPrefab.SetActive(false);

            //TODO: load actual characters instead of using prebuilt ones.
            #region make temorary characters
            #region Alamir Nightwanderer
            Character newChar = new Character(0, "Alamir Nightwanderer", Race.HALF_ELF, Alignment.LawfulGood);
            Characters.Add(newChar);
            #endregion

            #region Den_drummer
            newChar = new Character(0, "Den_drummer", Race.HUMAN, Alignment.ChaoticGood);
            Characters.Add(newChar);
            #endregion
            #endregion

            #region load characters

            //get the rect transform of the character list
            RectTransform rt = CharListArea.GetComponent<RectTransform>();

            //get the starting position so you don't override the prefab position
            Vector3 pos = CharSelectPrefab.transform.position;

            //reset list area size
            rt.sizeDelta = new Vector2(rt.sizeDelta.x, 4);

            //for each character of player
            foreach (Character character in Characters)
            {
                //create instance of the character select menu item
                GameObject charSelect = Instantiate(CharSelectPrefab, CharListArea.transform, false);

                //enable the instance
                charSelect.SetActive(true);

                //get the text object for the name
                GameObject CharNameText = charSelect.transform.Find("CharNameText").gameObject;

                //set the text to the character name
                CharNameText.GetComponent<Text>().text = character.CharName;

                //get the text object for the Id
                GameObject CharIdText = charSelect.transform.Find("CharNameText").gameObject;

                //set the text to the character name
                CharIdText.GetComponent<Text>().text = character.Id.ToString();

                //add the select to the CharSelects list
                CharSelects.Add(charSelect);

                //make the list area bigger to fit the new item and update the scrollbar
                rt.sizeDelta += new Vector2(0, 30);

                //move the prefab down so the next one doesn't overlap
                pos += new Vector3(0, -30, 0);
            }
            #endregion
        }

        public void SearchCharacters(string search = "")
        {
            if (search.Equals(""))
            {
                CharSelects.Where(cs => !cs.activeSelf);
            }
            else
            {

            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void SelectCharacter(Text IdText)
        {
            //find all buttons
            Button[] buttons = FindObjectsOfType<Button>().Where(b => b.CompareTag("CharDeselect")).ToArray();

            //disable deselect buttons so you only have 1 chracter selected at a time.
            foreach (Button b in buttons)
            {
                if (b.enabled)
                {
                    b.enabled = false;
                    b.transform.parent.Find("CharSelectButton").gameObject.SetActive(true);
                }
            }

            //convert the id back to a short
            short id;
            short.TryParse(IdText.text, out id);

            //Get the corresponding character
            Character character = Characters.First(c => c.Id == id);

            //TODO: fill the details canvas
        }
    }
}
