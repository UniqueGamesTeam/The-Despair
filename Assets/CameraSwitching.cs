using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitching : MonoBehaviour
{
    public GameObject CutScene;
    public Camera CutSceneCamera;
    public GameObject GameScene;
    
    // Start is called before the first frame update
    void Start()
    {
        CutScene.SetActive(false);
        CutSceneCamera.enabled = false;

        GameScene.SetActive(true);
    }

    // Update is called once per frame
   
    
}
