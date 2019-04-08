using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverEffectScipt : MonoBehaviour
{
    public GameOverBool gameOverScript;
    public Animator GameOverAnim;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameOverScript.GameOver==true)
        {
            GameOverAnim.SetBool("GameOver",true);
        }
    }
}
