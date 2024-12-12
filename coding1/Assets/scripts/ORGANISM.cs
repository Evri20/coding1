using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ORGANISM
{
    //vriables
    public string carbon;
    public string type;

    //make organism
    public ORGANISM(string carbon)
    {
        //ADD CARBON N TYPE
        this.carbon = carbon;
        type = "ORGANISM";
    }
    public virtual string showRecord()
    {
        return
            "Type: " + type + "\n" + "Carbon: " + carbon + "\n";
    }



}
