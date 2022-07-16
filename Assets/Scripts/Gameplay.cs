using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GamePlay : MonoBehaviour
{
    public TMP_Text Text1;
    private int counter;
    void Start()
    {
         counter = 0;
    }
    void Update()
    {
        Text1.text = "Score:" + counter;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name.CompareTo("RedSphere") == 0)
                counter = counter - 20;
                {
                    hit.collider.gameObject.SetActive(false);
                }
                if (hit.collider.gameObject.name.CompareTo("BlueSphere") == 0)
                counter = counter + 10;
                {
                    hit.collider.gameObject.SetActive(false);
                }
                if (hit.collider.gameObject.name.CompareTo("GreenSphere") == 0)
                counter = counter + 20;
                {
                    hit.collider.gameObject.SetActive(false);
                }
            }
        }
    }
}