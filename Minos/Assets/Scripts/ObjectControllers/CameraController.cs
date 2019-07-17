using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject sampleTile;

    // Start is called before the first frame update
    void Start()
    {
        Camera.main.orthographicSize = sampleTile.GetComponent<SpriteRenderer>().size.x*32 * Screen.height / Screen.width * 0.5f;
        Camera.main.transform.position = new Vector3(sampleTile.GetComponent<SpriteRenderer>().size.x * 16, -sampleTile.GetComponent<SpriteRenderer>().size.y * 11, -10);
    }
}
