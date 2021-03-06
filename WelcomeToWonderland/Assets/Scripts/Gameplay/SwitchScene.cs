﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SwitchScene : MonoBehaviour {

    public NewtonVR.NVRButton button;

    void Update()
    {
        if (button != null)
        {
            if (button.ButtonWasPushed) StartCoroutine(DelayedLoad(5, 1));

        }
    }


    public void LoadScene( int aInt)
    {
        SceneManager.LoadScene(aInt);
    }
    public IEnumerator DelayedLoad(int aInt, int scene)
    {
        yield return new WaitForSeconds(aInt);
        SceneManager.LoadScene(scene);
    }

    public void LoadScene(int delay, int scene)
    {
        StartCoroutine(DelayedLoad(5, 1));  


    }

}
