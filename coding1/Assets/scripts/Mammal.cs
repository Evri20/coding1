using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : ORGANISM
{
    public bool milkProduction;
    public string newborn;

    //make mammal sub class
    public Mammal(string carbon, string newborn, bool milkProduction) :
        base(carbon)
    {
        this.newborn = newborn;
        this.milkProduction = milkProduction;
        this.type = "Mammal";
    }

    public override string showRecord()
    {
        return base.showRecord() + "Milk Production: " + milkProduction + "\n" + "Newborn: " + newborn;
    }

    

}

