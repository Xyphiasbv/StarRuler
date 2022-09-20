using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galaxy 
{
    
    public static class GalaxyConfig{
        public static int NumPlayers = 6;
        public static int NumStars = 50;
    }
    // Start is called before the first frame update
    public Galaxy(){
        SolarSystems = new List<SolarSystem>();

    }

    public List<SolarSystem> SolarSystems;

    public SolarSystem GetSolarSystem(int solarSytemId){
        return SolarSystems[solarSytemId];
    }

    public void Generate(int numberOfStars){//int numPlayers

        for (int i = 0; i < numberOfStars; i++){
            SolarSystem ss = new SolarSystem();
            ss.Generate();

            SolarSystems.Add(ss);
        }
        
    }

    public void LoadFromFile(string fileName){

    }
    public void SaveToFile(){

    }
}
