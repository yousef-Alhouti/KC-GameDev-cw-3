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

        print("                     ");

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
        print("                     ");
        {
            float PlayerSpeed = 0.0F;
            float SetSpeed = 0.0F;
            float Speed = 2.5F;

            SetSpeed = Speed;
            PlayerSpeed = Speed;
           

            print(SetSpeed);
            print(Speed);
            print(PlayerSpeed);

        }
        print("                     ");
        {
            
            float NewSpeed = 10F;
            float OldSpeed = 10F;

            if (NewSpeed > OldSpeed)
            {
                print("The highest speed is");
                print(NewSpeed);
            }

            else if (NewSpeed == OldSpeed)
            {
                print("The highest speed is");
                print(NewSpeed);
                print("and");
                print(OldSpeed);
            }

            else
            {
                print("The highest speed is");
                print( OldSpeed);
            }

        }
    
    }


    // Update is called once per frame
    void Update()
    {
       
    }

    
}
