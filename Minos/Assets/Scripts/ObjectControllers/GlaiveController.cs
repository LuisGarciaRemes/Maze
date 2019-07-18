using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlaiveController : MonoBehaviour
{
    private float returnDelay;
    private float returnTimer;
    private float pickUpDelay;
    private float pickUpTimer;
    private bool pickUp;
    private bool goback;
    [SerializeField] private Collider2D physicsCol;
    [SerializeField] private GameObject owner;

    private void OnEnable()
    {
        pickUp = false;
        goback = false;
        returnTimer = 0;
        returnDelay = 1f;
        pickUpDelay = .25f;
        pickUpTimer = 0;
}

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(pickUp && collider.gameObject.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
            physicsCol.enabled = true;
        }
        else
        {
            returnTimer = 0;
        }
    }

    private void Update()
    {
        if (returnTimer >= returnDelay)
        {
            physicsCol.enabled = false;
            goback = true;
        }
        else
        {
            returnTimer += Time.deltaTime;
        }

        if (!pickUp)
        {
            if (pickUpTimer >= pickUpDelay)
            {
                pickUp = true;
            }
            else
            {
                pickUpTimer += Time.deltaTime;
            }
        }

        if(goback)
        {
            float step = 5 * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, owner.transform.position, step);
        }

    }

}
