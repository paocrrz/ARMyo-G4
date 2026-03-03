using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using com.rfilkov.kinect;

public class ChangeSceneButton : MonoBehaviour
{
     private bool levelLoaded;
    KinectManager kinectManager;

    // Start is called before the first frame update
    void Start()
    {
      // prevents multiple loads and create an instance of the KinectManager
        levelLoaded = false;
        kinectManager = KinectManager.Instance;
    }

    public void PlayARModeScene()
    {
        //only change scene if the kinectManager is initialized
        if (!levelLoaded && kinectManager && kinectManager.IsInitialized())
        {
            levelLoaded = true;
            SceneManager.LoadScene("EscenaAR");
        }
    }

    public void PlayVRModeScene()
    {
        //only change scene if the kinectManager is initialized
        if (!levelLoaded && kinectManager && kinectManager.IsInitialized())
        {
            levelLoaded = true;
            SceneManager.LoadScene("EscenaVR");
        }
    }

    public void PlayMixModeScene()
    {
        //only change scene if the kinectManager is initialized
        if (!levelLoaded && kinectManager && kinectManager.IsInitialized())
        {
            levelLoaded = true;
            SceneManager.LoadScene("EscenaVR");
        }
    }

    public void PlayMainModeScene()
    {
        //only change scene if the kinectManager is initialized
        if (!levelLoaded && kinectManager && kinectManager.IsInitialized())
        {
            levelLoaded = true;
            SceneManager.LoadScene("EscenaVR");
        }
    }

}
