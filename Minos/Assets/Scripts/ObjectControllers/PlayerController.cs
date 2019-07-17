using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed;
    private Rigidbody2D rb;
    [SerializeField] GameObject glaive;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 force = new Vector2(0.0f,0.0f);
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
        {
            force += new Vector2(0.0f, movementSpeed);
        }
        else if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            force += new Vector2(0.0f, -movementSpeed);
        }

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            force += new Vector2(-movementSpeed,0.0f);
        }
        else if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            force += new Vector2(movementSpeed, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.Space) && !glaive.activeSelf)
        {
            glaive.transform.position = this.gameObject.transform.position + new Vector3(force.normalized.x, force.normalized.y)/movementSpeed;
            glaive.SetActive(true);
            glaive.gameObject.GetComponent<Rigidbody2D>().AddForce(force*50);
        }

        rb.AddForce(force);
    }
}
