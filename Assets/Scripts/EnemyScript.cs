using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyScript : MonoBehaviour {

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    Animator anim;
        
    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Start(){

        anim = this.gameObject.GetComponent<Animator>();

    }

    void Update(){

        if ( Input.GetKeyDown( KeyCode.D ) ){ StartCoroutine( Anim() ); }

    }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private void OnCollisionEnter( Collision collision ){

        if ( collision.gameObject.name == "Bullet" ){

            anim.Play( "Die" );
            StartCoroutine( Anim() );

        }
        
    }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    IEnumerator Anim(){

        yield return new WaitForSeconds( 4 );
        Destroy( this.gameObject );
        PlayerScript.kills--;

    }

}