using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;

[System.Serializable]
public class Points {

    public string name;
    public GameObject point;

    [Range( 0, 360 )]
    public float rot;

    [HorizontalLine]

    public int kills;

}

public class CoreScript : MonoBehaviour {

    [Range(0, 5)]
    public int pN = 0;

    [Space]

    [Label("Points")]
    public Points[] p;

    public static bool idle;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
        
    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Start(){

        

    }

    void Update(){

        if ( pN != 0 ){

            PlayerScript.target = p[ pN - 1 ].point;
            PlayerScript.rot = p[ pN - 1 ].rot;

        }

    }

}