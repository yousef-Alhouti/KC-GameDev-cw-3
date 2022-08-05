using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string Heroname = "Ahmad";
    int heropower = 10;

    string VillianName = "Hamad";
    int VillainPower = 10;


 // Start is called before the first frame update
    void Start()
    {
        if (heropower > VillainPower)
        {
            print("The hero has more power!");
        }

        else if (heropower == VillainPower)
        {
            print("They both have the same power!");
        }

        else
        {
            print("The villian has more power than the hero!");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
