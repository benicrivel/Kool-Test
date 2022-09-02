using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ps;
    public GameObject ws;

    int bubbleCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Click/Touch on the hexagons
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo))
            {
                if(hitInfo.collider.gameObject.tag == "Hex")
                {
                    var rig = hitInfo.collider.GetComponent<MeshCollider>();
                    rig.gameObject.GetComponent<Hex>().RotateNow();
                }
            }
        }
    }

    public void SetPMActive()
    {
        ps.gameObject.SetActive(true);
    }

    public void SetPMDeactive()
    {
        ps.gameObject.SetActive(false);
    }

    public void IncreaseCount()
    {
        bubbleCount += 2;
        if(bubbleCount == 24)
        {
            ws.gameObject.SetActive(true);
        }
    }

    public int GetCount()
    {
        return bubbleCount;
    }
}
