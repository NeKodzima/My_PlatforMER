using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : MonoBehaviour
{
    public bool CanOpen = false;
    public GameObject[] drop;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            CanOpen = true;
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            CanOpen = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && CanOpen == true)
        {
            Instantiate(drop[Random.Range(0,drop.Length)], gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
