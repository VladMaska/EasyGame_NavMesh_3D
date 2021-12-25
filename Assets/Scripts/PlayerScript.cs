using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

using NaughtyAttributes;

public class PlayerScript : MonoBehaviour {

    public GameObject ui;

    public static GameObject target;
    public static bool move;

    [Space]

    [ShowAssetPreview]
    public GameObject weapon;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    NavMeshAgent agent;
    Animator anim;

    public static float rot;
    public static int kills = 0;
    public int k;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Start(){

        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = true;
        agent.updateUpAxis = true;

        anim = this.gameObject.GetComponent<Animator>();

        anim.SetBool( "Stay", true );        

    }

    void Update(){

        k = kills;

        if ( move ){

            anim.SetBool( "Run", true );
            anim.SetBool( "Stay", false );
            agent.SetDestination( target.transform.position );

        }
        else {

            //Idle();
            transform.eulerAngles = new Vector3( 0, rot, 0 );

        }

        if ( k == 0 ){ move = false; ui.SetActive( true ); }
        else { ui.SetActive( false ); }

    }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/   

    private void OnTriggerEnter( Collider other ){

        if ( other.name == target.name ){ StartCoroutine( Idle() ); }
        
    }

    private void OnTriggerStay( Collider other ){        

        if ( other.name != target.name ){ Switch(); }
        
    }

    void Switch(){

        weapon.SetActive( false );
        anim.SetBool( "Stay", false );
        anim.SetBool( "Idle", false );
        anim.Play( "Core" );
        move = true;

    }

    IEnumerator Idle(){

        move = false;
        anim.SetBool( "Run", false );
        anim.SetBool( "Idle", true );

        anim.Play( "Core" );

        yield return new WaitForSeconds( 1f );

        anim.SetBool( "Idle", false );
        anim.SetBool( "Stay", true );
        yield return new WaitForSeconds( 0.8f );
        weapon.SetActive( true );

    }

    void Stay(){

        move = false;
        anim.Play( "Core" );
        anim.SetBool( "Stay", true );
        weapon.SetActive( true );

    }

}