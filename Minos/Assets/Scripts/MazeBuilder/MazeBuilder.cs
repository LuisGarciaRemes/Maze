using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MazeBuilder : MonoBehaviour
{
    [SerializeField] private TextAsset maze;
    [SerializeField] private GameObject vert;
    [SerializeField] private GameObject horz;
    [SerializeField] private GameObject bottomleft;
    [SerializeField] private GameObject topleft;
    [SerializeField] private GameObject bottomright;
    [SerializeField] private GameObject topright;
    [SerializeField] private GameObject bottomcap;
    [SerializeField] private GameObject topcap;
    [SerializeField] private GameObject leftcap;
    [SerializeField] private GameObject rightcap;
    [SerializeField] private GameObject solo;


    // Start is called before the first frame update
    void Start()
    {     
        string[] rows = maze.text.Split('\n');
        float width = 0;
        float height = 0;
        float x = (solo.GetComponent<SpriteRenderer>().size.x);
        float y = (solo.GetComponent<SpriteRenderer>().size.y);

        height = rows.Length;
        width = rows[0].Length;

        for (int i = 0; i < rows.Length; i++)
        {
            string[] row = rows[i].Split(',');           

            for (int j = 0; j < row.Length; j++)
            {
               string tile = row[j];

                if (tile.Trim().Equals("|"))
                {
                    Instantiate(vert, new Vector3(j * x + x / 2, -i * y - y / 2, 0.0f), new Quaternion(),this.gameObject.transform);
                }
                else if (tile.Trim().Equals("_"))
                {
                    Instantiate(horz, new Vector3(j * x + x / 2, -i * y - y / 2, 0.0f), new Quaternion(), this.gameObject.transform);
                }
                else if (tile.Trim().Equals("L"))
                {
                    Instantiate(bottomleft, new Vector3(j * x + x / 2, -i * y - y / 2, 0.0f), new Quaternion(), this.gameObject.transform);
                }
                else if (tile.Trim().Equals("J"))
                {
                    Instantiate(bottomright, new Vector3(j * x + x / 2, -i * y - y / 2, 0.0f), new Quaternion(), this.gameObject.transform);
                }
                else if (tile.Trim().Equals("F"))
                {
                    Instantiate(topleft, new Vector3(j * x + x / 2, -i * y - y / 2, 0.0f), new Quaternion(), this.gameObject.transform);
                }
                else if (tile.Trim().Equals(">"))
                {
                    Instantiate(rightcap, new Vector3(j * x + x / 2, -i * y - y / 2, 0.0f), new Quaternion(), this.gameObject.transform);
                }
                else if (tile.Trim().Equals("<"))
                {
                    Instantiate(leftcap, new Vector3(j * x + x / 2, -i * y - y / 2, 0.0f), new Quaternion(), this.gameObject.transform);
                }
                else if (tile.Trim().Equals("^"))
                {
                    Instantiate(topcap, new Vector3(j * x + x / 2, -i * y - y / 2, 0.0f), new Quaternion(), this.gameObject.transform);
                }
                else if (tile.Trim().Equals("V"))
                {
                    Instantiate(bottomcap, new Vector3(j * x + x / 2, -i * y - y / 2, 0.0f), new Quaternion(), this.gameObject.transform);
                }
                else if (tile.Trim().Equals("O"))
                {
                    Instantiate(solo, new Vector3(j * x + x / 2, -i * y - y / 2, 0.0f), new Quaternion(), this.gameObject.transform);
                }
                else if (tile.Trim().Equals("7"))
                {
                    Instantiate(topright, new Vector3(j * x + x / 2, -i * y - y / 2, 0.0f), new Quaternion(), this.gameObject.transform);
                }
            }
        }
        this.gameObject.GetComponent<SpriteRenderer>().size = new Vector2(x*width*.535f, y * height);
    }
}
