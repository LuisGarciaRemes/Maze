using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlaiveController : MonoBehaviour
{
    private float delay;
    private float timer;
    private bool pickUp;

    private void OnEnable()
    {
        pickUp = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if((collision.gameObject.CompareTag("Player") && pickUp)||(collision.gameObject.CompareTag("Player") && this.gameObject.GetComponent<Rigidbody2D>().velocity.Equals(new Vector2(0.0f,0.0f))))
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            pickUp = true;
        }
    }

}
