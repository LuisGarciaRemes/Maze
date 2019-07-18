using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject sampleTile;
    [SerializeField] private GameObject Player;
    [SerializeField] private float OnScreenTileHeight;


    // Start is called before the first frame update
    void Start()
    {
        Camera.main.orthographicSize = sampleTile.GetComponent<SpriteRenderer>().size.x* OnScreenTileHeight * Screen.height / Screen.width * 0.5f;
    }

    private void Update()
    {
        Camera.main.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, -10);
    }


}
