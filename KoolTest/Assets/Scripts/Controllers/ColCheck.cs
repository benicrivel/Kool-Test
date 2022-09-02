using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColCheck : MonoBehaviour
{
    public GameObject fellowSpot;
    public string targetTag;

    public float timeForPops;

    public GameController gc;

    private void Start()
    {
        
        targetTag = fellowSpot.transform.GetChild(0).tag;
        Debug.Log("Entered Tags " + targetTag);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided");

        if (other.gameObject.tag == targetTag)
        {
            //Destroy both bubbles
            StartCoroutine(WaitALittle(timeForPops));
            Debug.Log(""+other);
            //Destroy(fellowSpot.transform.GetChild(0).gameObject);
            gc.IncreaseCount();
            Destroy(fellowSpot.transform.gameObject);
            Destroy(other.gameObject);
            Debug.Log("" + gc.GetCount());
            Destroy(this);
        }
    }

    IEnumerator WaitALittle(float f)
    {
        yield return new WaitForSeconds(f);
    }
}
