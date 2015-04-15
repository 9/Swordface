﻿using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
  public Rigidbody2D rocket;				// Prefab of the rocket.
  public float speed = 20f;				// The speed the rocket will fire at.


//  private PlayerControl playerCtrl;		// Reference to the PlayerControl script.
  private Animator anim;					// Reference to the Animator component.

  private GameObject PlayerReference;


  void Awake()
  {
    // Setting up the references.
    //anim = transform.root.gameObject.GetComponent<Animator>();
    //playerCtrl = transform.root.GetComponent<PlayerControl>();
    PlayerReference = transform.parent.gameObject;
  }


  void Update()
  {
    // If the fire button is pressed...
    if (Input.GetKeyDown(KeyCode.X))
    {
      // ... set the animator Shoot trigger parameter and play the audioclip.
      //anim.SetTrigger("Shoot");
      //GetComponent<AudioSource>().Play();

      // If the player is facing right...
        // ... instantiate the rocket facing right and set it's velocity to the right. 
        Rigidbody2D bulletInstance = Instantiate(rocket, transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as Rigidbody2D;
        bulletInstance.velocity = new Vector2(PlayerReference.GetComponent<Rigidbody2D>().velocity.x + speed, 0);
        // Otherwise instantiate the rocket facing left and set it's velocity to the left.
    }
  }
}