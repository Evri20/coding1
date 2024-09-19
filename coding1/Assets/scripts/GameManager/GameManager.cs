using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //variables 
    public TextMeshProUGUI score;
    public int sc_num;
    
    // Start is called before the first frame update
    void Start()
    {
        //make score 0
        sc_num = 0;
        score.text = "Score: " + sc_num;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + sc_num;
    }
}
