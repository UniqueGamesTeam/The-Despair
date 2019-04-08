using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
   private Vector3 firstpoint; //change type on Vector3
  private Vector3 secondpoint;
  private float xAngle  = 0.0f; //angle for axes x for rotation
  private float yAngle  = 0.0f;
  private float xAngTemp = 0.0f; //temp variable for angle
  private float yAngTemp = 0.0f;
  public float XSensitivity=2f;
  public float YSensitivity=2f;
  public CameraZone cameraZone;
  void Awake() 
  {
   //Initialization our angles of camera

   this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0.0f);
   XSensitivity = PlayerPrefs.GetFloat("MouseSens");
   YSensitivity = PlayerPrefs.GetFloat("MouseSens");
  }
  void Update() {
   //Check count touches
   if(cameraZone.isOnCameraPanel==true)
   {
   if(Input.touchCount > 0) 
   {
    //Touch began, save position
    if(Input.GetTouch(0).phase == TouchPhase.Began) 
    {
     firstpoint = Input.GetTouch(0).position;
     xAngTemp = xAngle;
     yAngTemp = yAngle;
    }
    //Move finger by screen
    if(Input.GetTouch(0).phase==TouchPhase.Moved) 
    {
     secondpoint = Input.GetTouch(0).position;
     //Mainly, about rotate camera. For example, for Screen.width rotate on 180 degree
     xAngle = xAngTemp + (secondpoint.x - firstpoint.x) * 15 * XSensitivity / Screen.width;
     yAngle = yAngTemp - (secondpoint.y - firstpoint.y) *10* YSensitivity / Screen.height;
     //Rotate camera
     this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0.0f);
    }
    if(Input.GetTouch(1).phase == TouchPhase.Began) 
    {
     firstpoint = Input.GetTouch(1).position;
     xAngTemp = xAngle;
     yAngTemp = yAngle;
    }
    //Move finger by screen
    if(Input.GetTouch(1).phase==TouchPhase.Moved) 
    {
     secondpoint = Input.GetTouch(1).position;
     //Mainly, about rotate camera. For example, for Screen.width rotate on 180 degree
     xAngle = xAngTemp + (secondpoint.x - firstpoint.x) * 15*XSensitivity / Screen.width;
     yAngle = yAngTemp - (secondpoint.y - firstpoint.y) *10*YSensitivity / Screen.height;
     //Rotate camera
     this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0.0f);
    }
    if(Input.GetTouch(2).phase == TouchPhase.Began) 
    {
     firstpoint = Input.GetTouch(2).position;
     xAngTemp = xAngle;
     yAngTemp = yAngle;
    }
    //Move finger by screen
    if(Input.GetTouch(2).phase==TouchPhase.Moved) 
    {
     secondpoint = Input.GetTouch(2).position;
     //Mainly, about rotate camera. For example, for Screen.width rotate on 180 degree
     xAngle = xAngTemp + (secondpoint.x - firstpoint.x) * 15*XSensitivity / Screen.width;
     yAngle = yAngTemp - (secondpoint.y - firstpoint.y) *10*YSensitivity / Screen.height;
     //Rotate camera
     this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0.0f);
    }
   }
   }
   }                                              //The key point is use localRotation,not rotation or Quaternion.Rotate.
     
}
