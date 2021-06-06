using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static Action OnClickSpin;
    public static Action DoReset;
    public static GameManager instance;
    private float anglePerSecion;
    private float numberIndex;
    [SerializeField] GameObject pointerParent;
    [SerializeField] Transform pointerObject;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

        Global.numberList.Reverse();
        anglePerSecion = 360.0f / Global.section;

    }
  
    public void OnSpin()
    {
        if (Global.selectedNumber < 0)
        {
            Debug.Log("Please Select A Number From Dropdown");
            return;
        }
        Global.isSpinning = true;
        Global.StopTheBall = false;
        CalculateBallPosition();
        OnClickSpin();

    }

    private void CalculateBallPosition()
    {
        numberIndex = Global.numberList.IndexOf(Global.selectedNumber);
        float offset = 0;
        if(numberIndex<18)
        {
            offset = -5;
        }
        pointerParent.transform.eulerAngles = new Vector3( 0, offset - (numberIndex+1) * anglePerSecion,0);
        pointerParent.transform.parent = Global.wheelTransform;


    }

   
    public void CheckBallPosition()
    {

        if (Math.Abs(pointerObject.position.x -Global.ballPosition.x) <= 0.5f
            && Math.Abs(pointerObject.position.z - Global.ballPosition.z) <= 0.5)
        {
            Global.StopTheBall = true;
            Global.ballTransform.parent = Global.wheelTransform;
        }
    
    }

    public void onClickReset()
    {
        Global.isSpinning = false;
        SceneManager.LoadScene("GamePlay");

    }
}
