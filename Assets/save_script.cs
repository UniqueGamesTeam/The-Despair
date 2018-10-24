using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class save_script : MonoBehaviour
{

    public GameObject Cur_play_position;
    public BulletsScipt bulletsScipt;
    public GameObject Text_save;
    public Animator Save_anim;
    private GameObject bottle;
    public GameObject My_bootle;
    public GameObject pistol;
    public GameObject hand_1;
    public GameObject hand_2;
    private bool check = false;


    void Start()
    {
        bottle = GameObject.Find("bottle_for_save");
    }
    public void Save()
    {
        try
        {
            PlayerPrefs.DeleteKey("PosX");
            PlayerPrefs.DeleteKey("PosY");
            PlayerPrefs.DeleteKey("PosZ");
            PlayerPrefs.DeleteKey("BulletsInClip");
            PlayerPrefs.DeleteKey("BulletsLeft");
        }
        catch
        {
            Debug.Log("You does't have Save");
        }

        PlayerPrefs.SetFloat("PosX", Cur_play_position.transform.position.x);
        PlayerPrefs.SetFloat("PosY", Cur_play_position.transform.position.y);
        PlayerPrefs.SetFloat("PosZ", Cur_play_position.transform.position.z);
        PlayerPrefs.SetInt("BulletsInClip", bulletsScipt.BulletsInClip);
        PlayerPrefs.SetInt("BulletsLeft", bulletsScipt.BulletsLeft);
        StartCoroutine(AnimatorSetFire());


        Debug.Log("Save");
    }
    public void OnTriggerStay(Collider box)
    {

        if (box.gameObject.tag == "Main_Player")
        {
            Text_save.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Save();
            }
        }
    }
    public void OnTriggerExit(Collider box)
    {

        if (box.gameObject.tag == "Main_Player")
        {
            Text_save.SetActive(false);
        }

    }
    public IEnumerator AnimatorSetFire()
    {

        if (pistol.activeSelf == true)
        {
            check = true;
            pistol.SetActive(false);
            hand_1.SetActive(true);
            hand_2.SetActive(true);
        }
        Destroy(transform.GetChild(0).gameObject);
        My_bootle.SetActive(true);
        Save_anim.SetBool("Save", true);
        yield return new WaitForSeconds((float)2.5);

        Save_anim.SetBool("Save", false);
        My_bootle.SetActive(false);
        if (check == true)
        {

            hand_1.SetActive(false);
            hand_2.SetActive(false);

            pistol.SetActive(true);
            check = false;
        }
    }

}

