using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class Directory : MonoBehaviour
{
    public TextMeshProUGUI displayText;
    public List<ORGANISM> organisms;
    public int recordNUM = 0;




    private void Start()
    {
        organisms = new List<ORGANISM>();
        ORGANISM first = new ORGANISM("carbon based being");
        ORGANISM second = new Mammal("carbon based being", "newborns are not in eggs", true);
        ORGANISM third = new Humans("carbon based being", "newborns are not in eggs", true, "Sweat", "English", "Critcal Thought");
        ORGANISM fourth = new Individual("Evri", "Brown", "carbon based being", "newborns are not in eggs", true, "Sweat", "English", "Critcal Thought");

        organisms.Add(first);
        organisms.Add(second);  
        organisms.Add(third);   
        organisms.Add(fourth);

        UpdateRecord();
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space) && recordNUM < organisms.Count)
        {
            UpdateRecord();
        }
    }
    void UpdateRecord()
    {
        ORGANISM currentThing = organisms[recordNUM % organisms.Count];

        displayText.text = currentThing.showRecord();

        recordNUM++;
    }
}
