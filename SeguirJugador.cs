using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SeguirJugador : MonoBehaviour
{

    public NavMeshAgent enemic;
    public Transform Player;
    public AudioSource woof;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        enemic.SetDestination(Player.position);
        if(enemic.remainingDistance >= 0 && enemic.remainingDistance <= 3.6f){
          woof.Play(); 
        }
    }
}
