using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using NaughtyAttributes;

public class PlayerShoot : MonoBehaviour {

    [ShowAssetPreview]
    public GameObject bullet;
    public GameObject shootPos;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Update(){
        
        if ( Input.GetTouch(0).phase == TouchPhase.Ended && !PlayerScript.move ){

            Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
            RaycastHit hit;

            if ( Physics.Raycast( ray, out hit, Mathf.Infinity ) ){

                print( hit.point );

                GameObject b = Instantiate( bullet, shootPos.transform.position, Quaternion.identity );
                b.name = "Bullet";

                Bullet bs = b.AddComponent<Bullet>();
                bs.pos = hit.point;

            }

        }

    }

}