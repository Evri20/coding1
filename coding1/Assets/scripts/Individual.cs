using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Individual : Humans
{
    public string Name;
    public string haircolor;


    public Individual(string name, string haircolor, string carbon, string newborn, bool milkProduction, string sweat, string speakLanguage, string critThink):
        base(carbon, newborn, milkProduction, sweat, speakLanguage, critThink)
    {
        this.Name = name;
        this.haircolor = haircolor;
        this.type = "Individual";
    }

    public override string showRecord()
    {
        return base.showRecord() + "Name: " + Name + "\n" + "Hair Color: " + haircolor;
    }

}
