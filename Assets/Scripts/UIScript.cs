using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {
    
    public void Next(){

        CoreScript core = GameObject.Find( "Core" ).GetComponent<CoreScript>();

        if ( core.pN != 5 ){

            core.pN++;
            PlayerScript.kills = core.p[ core.pN - 1 ].kills;
            PlayerScript.move = true;

        }
        else {

            SceneManager.LoadScene( "Game" );

        }

    }

}