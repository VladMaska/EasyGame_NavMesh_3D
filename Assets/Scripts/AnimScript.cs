using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AnimScript : MonoBehaviour {

    public bool idle;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    Animator anim;
        
    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Start(){

        anim = this.gameObject.GetComponent<Animator>();

        anim.SetLayerWeight( 0, 0.5f );

    }

    void Update(){

        Switch();

        //anim.setA

        if ( Input.GetKeyDown( KeyCode.R ) ){

            anim.Play( "Core" );

        }

        //if ( idle ){
        //    anim.SetTrigger( "Idle");
        //}
        //else {
        //    anim.ResetTrigger( "Idle" );
        //}

    }

    void Switch(){

        if ( idle && Input.GetKeyDown( KeyCode.K ) ){ idle = false; }
        else if ( !idle && Input.GetKeyDown( KeyCode.K ) ){ idle = true; }

    }

}