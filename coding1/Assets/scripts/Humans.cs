using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humans : Mammal
{
    public string sweat;
    public string speakLanguage;
    public string critThink;


    public Humans(string carbon, string newborn, bool milkProduction, string sweat, string speakLanguage, string critThink) :
        base(carbon, newborn, milkProduction)
    {
        this.speakLanguage = speakLanguage;
        this.critThink = critThink; 
        this.sweat = sweat;
        this.type = "Human";
    }

    public override string showRecord()
    {
        return base.showRecord() + "Seat: " + sweat + "\n" + "Speak Language: " + speakLanguage + "\n" + "Crtitical Thought: " + critThink + "\n";
    }

}
