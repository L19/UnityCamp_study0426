using UnityEngine;
using System.Collections;

namespace UnityCamp_study0426.Completed
{
	public class FollowCamera : MonoBehaviour
	{
		public Transform ballTransform;
		private Vector3 startPosition;
		private Vector3 relativePosition;
		private GameManager gameManager;

		void Reset ()
		{
			ballTransform = GameObject.Find ("Ball").transform;
		}

		void Start ()
		{
			gameManager = GameManager.Instance;
			startPosition = transform.position;

			if (ballTransform != null) {
				relativePosition = startPosition - ballTransform.position;
			} else {
				relativePosition = Quaternion.Euler (20f, 0f, 0f) * new Vector3 (0f, 3.5f, -3f);
			}
		}

		void Update ()
		{
			if (gameManager.playerStatus != GameManager.PlayerState.Result) {
				Vector3 newPosition = ballTransform.position + relativePosition;
				transform.position = Vector3.Lerp (transform.position, newPosition, 3f * Time.deltaTime);
			}
		}

		void OnTriggerEnter (Collider col)
		{
			if (col.tag == "EndLine") {
				gameManager.playerStatus = GameManager.PlayerState.Result;
			}
		}
	}
}