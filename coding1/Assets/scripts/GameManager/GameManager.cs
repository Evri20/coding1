using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //variables 
    //make it a simpleton
    public static GameManager instance;

    private bool starting = true;

    public TextMeshProUGUI score;
    public int sc_num;
    public TextMeshProUGUI p3score;
    public int p3sc_num;

    //awake is called on spawn on this script
    private void Awake()
    {
        //a singleton mst only have only one instance and check if there is only one instance
        //if it is, make sure its not destroyed, if its not destroy this instance
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //make score 0
        sc_num = 0;
        score.text = "Score: " + sc_num;
        p3sc_num = 0;

    
    
    
    
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + sc_num;
        p3score.text = "Score: " + p3sc_num;
    }

    public void StartGame()
    {
       
        if (starting)
        {
            SceneManager.LoadScene("GameScene");
            starting = false;
        }
    }



}

