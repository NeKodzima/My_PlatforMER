using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    public bool CanOpen = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && PlayerCount.keys > 0)
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
            Destroy(gameObject);
        }
    }
}
