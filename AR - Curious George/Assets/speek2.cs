using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class speek2 : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject button;
    public GameObject person;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("lacy_button2");
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        //cubeAni.GetComponent<Animator>();

        person = GameObject.Find("cop2");
        person.GetComponent<GameObject>();
        person.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        person.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        person.SetActive(false);
    }


}
