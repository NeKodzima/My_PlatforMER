using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OpenMiniMap : MonoBehaviour
{
    public RawImage rawImage;
    public CharacterController2D PM;
    void Start()
    {
        PM = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController2D>();


    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) && PM.m_Grounded && PlayerMovement.CanMove)
        {
            rawImage.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
            if (Input.GetKeyUp(KeyCode.M) && PM.m_Grounded && PlayerMovement.CanMove)
            {
                rawImage.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
    }
}
