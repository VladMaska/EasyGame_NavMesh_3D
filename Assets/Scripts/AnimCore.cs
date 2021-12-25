using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AnimCore : MonoBehaviour {

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    Animator anim;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    public AnimCore( Animator anim ){

        this.anim = anim;

    }
        
    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Start(){

        

    }

    void Update(){

        

    }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    public void S( string name ) => anim.SetTrigger( name );
    public void R( string name ) => anim.ResetTrigger( name );

}