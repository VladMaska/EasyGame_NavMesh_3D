using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bullet : MonoBehaviour {

    public Vector3 pos;
    
    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
        
    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Start(){

        

    }

    void Update(){

        transform.position = Vector3.MoveTowards( transform.position, pos, 0.1f );

    }

    private void OnCollisionEnter( Collision collision ){ Destroy( this.gameObject ); }

}