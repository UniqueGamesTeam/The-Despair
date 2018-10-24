using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour {

    public Transform Cur_play_position;
    public BulletsScipt bulletsScipt;

    public void Load_met(){
        Transform Cur_play_position = this.gameObject.transform;
        Vector3 Player_Position = new Vector3(PlayerPrefs.GetFloat("PosX"), PlayerPrefs.GetFloat("PosY"), PlayerPrefs.GetFloat("PosZ"));
        bulletsScipt.BulletsInClip = PlayerPrefs.GetInt("BulletsInClip");
        bulletsScipt.BulletsInClip = PlayerPrefs.GetInt("BulletsInClip");
        Cur_play_position.position = Player_Position;

    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            
                Load_met();
            
     
            
        }
    }
}
