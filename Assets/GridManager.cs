using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridManager : MonoBehaviour
{
    public GameObject gridPrefab;
    public int columnLenght, rowHeight;
    private GameObject[,] grid;
    public float gridOffset = 1f;
    public string bName;
    // public GameObject birdsText;
    public TextMesh birdsText;
    // Start is called before the first frame update
    void Start()
    {
        List<string> birdlist = new List<string>();
        birdlist.Add("Hudhud");
        birdlist.Add("Eagle");
        birdlist.Add("Parrot");
        birdlist.Add("Crow");
        for (int i = 0; i < columnLenght; i += 2)
        {
            for (int j = 0; j < rowHeight; j += 2)
            {
                Instantiate(gridPrefab, new Vector3(i, 0, j), Quaternion.identity);
               
                var randombird = Random.Range(0, birdlist.Count);
                birdsText.text = birdlist[randombird].ToString();
                Instantiate(birdsText, new Vector3(i, 0, j), birdsText.transform.rotation);

                /*foreach (GridManager bird in birdlist)
                {
                    Debug.Log(bird.bName);
                }*/





            }
        }
       

    }

    // Update is called once per frame
    void Update()
    {
       
       
    }
    public GridManager(string birdName)
    {
        bName = birdName;
    }
}

