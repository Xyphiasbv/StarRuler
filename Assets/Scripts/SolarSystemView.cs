using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemView : MonoBehaviour
{
    GameController gameController;
    public GameObject star;
    public GameObject planet;
    public GameObject moon;
    SolarSystem solarSystem;
    void Start()
    {
        gameController = GameObject.FindObjectOfType<GameController>();
        //showSolarSystem(0);   
    }

    public void showSolarSystem(int solarSystemId){

        while(transform.childCount > 0){
            Transform c = transform.GetChild(0);
            c.SetParent(null);
            Destroy(c.gameObject);
        }

        solarSystem = gameController.galaxy.SolarSystems[solarSystemId];
        for (int i = 0; i < solarSystem.children.Count; i++){
            GameObject newStar = Instantiate(star, solarSystem.Position, Quaternion.identity) as GameObject;
            newStar.transform.SetParent(this.transform);
            SpawnPlanets(newStar.transform, solarSystem.children[i]);
        }

    }

    void SpawnPlanets(Transform transformParent, Celestial c){
        for (int i = 0; i < c.children.Count; i++){
            GameObject newPlanet = Instantiate(planet, c.children[i].Position, Quaternion.identity) as GameObject;
            newPlanet.transform.SetParent(transformParent);
            GameObject newMoon = Instantiate(moon, c.children[i].children[0].Position, Quaternion.identity) as GameObject;
            newMoon.transform.SetParent(newPlanet.transform);
        }
    }

    private void OnMouseDown()
    {
        gameController = GameObject.FindObjectOfType<GameController>();
        showSolarSystem(0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
