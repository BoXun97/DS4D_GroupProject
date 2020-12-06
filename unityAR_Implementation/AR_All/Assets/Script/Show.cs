using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using Vuforia;

public class Show : MonoBehaviour
{
    public bool IsShow;
    public GameObject Model_1;
    public GameObject Model_2;
    public void Shows()
    {
            if (IsShow)
            {
                Model_1.SetActive(false);
                Model_2.SetActive(true);
                IsShow = false;
            }
            else
            {
                Model_1.SetActive(true);
                Model_2.SetActive(false);
            IsShow = true;
        }
    }
}
