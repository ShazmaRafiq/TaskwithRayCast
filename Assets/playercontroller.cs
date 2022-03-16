using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public int columnLenght, rowHeight;
    Ray xray, xrayx, zray, zrayz;
    RaycastHit ray;
    // Start is called before the first frame update
    void Start()
    {
        GridManager gm = GameObject.FindGameObjectWithTag("grid").GetComponent<GridManager>();
        Rigidbody playerrb = GetComponent<Rigidbody>();
        playerrb.position = new Vector3(gm.rowHeight - gm.rowHeight, transform.position.y, gm.columnLenght - gm.columnLenght);
    }

    // Update is called once per frame
    void Update()
    {
        zray = new Ray(new Vector3(transform.position.x, transform.position.y - 1, transform.position.z + 0.5f), Vector3.forward);
        if (Input.GetKeyDown("w"))
        {
            Debug.Log("pressed w");
            if (Physics.Raycast(zray, out ray, 2f))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2);
            }
        }
        zrayz = new Ray(new Vector3(transform.position.x, transform.position.y - 1, transform.position.z - 0.5f), Vector3.back);
        if (Input.GetKeyDown("s"))
        {
            if (Physics.Raycast(zrayz, out ray, 2f))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 2);
            }
        }
        xrayx = new Ray(new Vector3(transform.position.x + 0.5f, transform.position.y - 1, transform.position.z), Vector3.left);
        if (Input.GetKeyDown("a"))
        {
            if (Physics.Raycast(xrayx, out ray, 2f))
            {
                transform.position = new Vector3(transform.position.x - 2, transform.position.y, transform.position.z);
            }
        }
        xray = new Ray(new Vector3(transform.position.x + 0.5f, transform.position.y - 1, transform.position.z), Vector3.right);
        if (Input.GetKeyDown("d"))
        {
            if (Physics.Raycast(xray, out ray, 2f))
            {
                transform.position = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
            }
        }










    }
}
