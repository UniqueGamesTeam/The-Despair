using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour {

    public Transform Cur_play_position;
    public BulletsScipt bulletsScipt;
    public save_script save;
    public void Start()
    {
        Transform Cur_play_position = this.gameObject.transform;
        Vector3 Player_Position = new Vector3(PlayerPrefs.GetFloat("PosX"), PlayerPrefs.GetFloat("PosY"), PlayerPrefs.GetFloat("PosZ"));
        bulletsScipt.BulletsInClip = PlayerPrefs.GetInt("BulletsInClip");
        bulletsScipt.BulletsInClip = PlayerPrefs.GetInt("BulletsInClip");
        Cur_play_position.position = Player_Position;
        save.num = PlayerPrefs.GetInt("Num");
        save.index = PlayerPrefs.GetInt("Index_");




        for (int i = 0; i < save.num; i++)
        {

            GameObject zombies = GameObject.Find(PlayerPrefs.GetString("Name_zombies" + i));

            
                zombies.SetActive(false);
            
            


        }
    }
    public void Load_met()
    {
        Transform Cur_play_position = this.gameObject.transform;
        Vector3 Player_Position = new Vector3(PlayerPrefs.GetFloat("PosX"), PlayerPrefs.GetFloat("PosY"), PlayerPrefs.GetFloat("PosZ"));
        bulletsScipt.BulletsInClip = PlayerPrefs.GetInt("BulletsInClip");
        bulletsScipt.BulletsInClip = PlayerPrefs.GetInt("BulletsInClip");
        Cur_play_position.position = Player_Position;
        save.num = PlayerPrefs.GetInt("Num");
        save.index = PlayerPrefs.GetInt("Index");
        for (int i = 0; i == save.num; i++)
        {
            GameObject zombies = GameObject.Find(PlayerPrefs.GetString("Name_zombies" + i));
            zombies.SetActive(false);

        }
        // GameObject.Find("Zombie").SetActive(false);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {

            Load_met();



        }
        if (Input.GetKeyDown(KeyCode.B))
        {

            Delet();



        }

    }
    void Delet()
    {
        Debug.Log("Delete");
        for (int i = 0; i < 100; i++)
        {

            PlayerPrefs.DeleteKey("Name_zombies" + i);

        }
        save.num = 0;
        save.index = 0;
    }
}
