using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;

    public GameObject[] panels;

    public void page1()
    { 
        panel1.SetActive(true);
        panel2.SetActive(false);
        panel3.SetActive(false);
    }

    public void page2()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
        panel3.SetActive(false);
    }

    public void page3()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(true);
    }


}
