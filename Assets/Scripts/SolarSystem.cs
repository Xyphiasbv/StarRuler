using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : Celestial
{
    public void Generate(){
        Celestial newStar = new Celestial();

        Celestial planet = new Celestial();

        newStar.Parent = this;
        this.Children.add(newStar);

    }

    
}
