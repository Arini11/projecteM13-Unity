using System;
using UnityEngine;
 
public class PlayerShoot : MonoBehaviour {
 
    private const string PLAYER_TAG = "Player"; 
 
    [SerializeField]
    private LayerMask mask;
 
    void Start ()
    {
        
    }
 
    void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
 
    void Shoot ()
    {

        Ray ray = new Ray(transform.position, transform.forward);
        //Debug.DrawRay(ray.origin, ray.direction * 10);
        //Debug.Log(" has been shot.");
 
    }
 
    void CmdPlayerShot ()
    {
        //Debug.Log(" has been shot.");
    }
 
}
 