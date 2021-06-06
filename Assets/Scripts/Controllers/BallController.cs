using System.Collections;
using UnityEngine;

public class BallController : MonoBehaviour
{
	[SerializeField] Transform targetRotation;
	[SerializeField] Transform targetPosition;

	GameObject ballparent;
	Transform ballInitialpos;
	float elapsedTime = 0;
    private float ballSpeed;

    private void OnEnable()
	{
		GameManager.OnClickSpin += OnClickSpin;
		Global.ballTransform = transform;
		ballInitialpos = transform;
		ballparent = transform.parent.gameObject;

	}

	private void OnDisable()
	{
		GameManager.OnClickSpin -= OnClickSpin;

	}
	public void OnClickSpin()
	{
		StartCoroutine(RotateTheBall());
	}
	IEnumerator RotateTheBall()
	{

		float max = Random.Range(75, 100);
		float time = Time.deltaTime;
		while (ballSpeed >= 0 && Global.isSpinning)
		{
			ballSpeed = Mathf.Lerp(max,0, time/Global.ballRoatationDuration );
			time += Time.deltaTime;
			if (ballSpeed < 70)
			{
				if (Vector3.Distance(transform.position, targetRotation.position) > 4)
				{
					transform.position = Vector3.Lerp(transform.position, targetRotation.position, (elapsedTime / Global.ballRoatationDuration) * Time.deltaTime);
					elapsedTime += Time.deltaTime;

				}
				else if (Vector3.Distance(transform.position, targetRotation.position) < 4)
				{
					Global.ballAngle = Mathf.RoundToInt(transform.eulerAngles.y);
					Global.ballPosition = transform.position;

					if (Global.StopTheBall)
					{
						StopCoroutine(RotateTheBall());
						yield break;
					}

				}
			}
			Vector3 dir = targetRotation.position- transform.position ;

			transform.RotateAround(targetRotation.transform.position, -Vector3.up, ballSpeed * Time.deltaTime);
			yield return null;

		}
	}

  
}
