using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    private float wheelSpeed;

    private void Start()
	{
		Global.isSpinning = true;
		Global.wheelTransform = transform;

	}
	private void OnEnable()
    {
		GameManager.OnClickSpin += SpinTheWeel;

	}

    private void OnDisable()
    {
		GameManager.OnClickSpin -= SpinTheWeel;

	}
	public void SpinTheWeel()
    {
		StartCoroutine(RotateTheWheel());
	}
	IEnumerator RotateTheWheel()
	{

		float maxSpeeed = Random.Range(150, 250);
		wheelSpeed = maxSpeeed;
		float lapsedTime = 0;
		while (wheelSpeed >= 0 )
		{

			lapsedTime += Time.deltaTime;
			wheelSpeed = Mathf.Lerp(0, maxSpeeed,Global.wheelRoatationDuration / lapsedTime);
			transform.RotateAround(transform.position, Vector3.up, wheelSpeed * Time.deltaTime);
			Global.wheelTransform = transform;
			if( wheelSpeed<20)
            {
				Global.wheelAngle = Mathf.RoundToInt(transform.eulerAngles.y);
				GameManager.instance.CheckBallPosition();

			}
			yield return new WaitForEndOfFrame();

		}
		yield return null;

	}


}
