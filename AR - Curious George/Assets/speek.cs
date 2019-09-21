using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class speek : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject button;
    public GameObject review;
    public GameObject info;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("lacy_button3");
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        //cubeAni.GetComponent<Animator>();

        review = GameObject.Find("review");
        review.GetComponent<GameObject>();
        review.SetActive(false);
    }

    int flag = 0;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (review.activeSelf == false)
        {
            review.SetActive(true);
            info.SetActive(false);
        }

        else if (review.activeSelf == true)
        {
            review.SetActive(false);
            info.SetActive(true);
        }

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        


    }


}
