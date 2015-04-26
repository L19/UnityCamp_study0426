using UnityEngine;
using System.Collections;

namespace UnityCamp_study0426.Completed
{
	public class BallController : MonoBehaviour
	{
		public float shotPower = 70f;
		private Rigidbody rb;
		private GameManager gameManager;

		void Start ()
		{
			gameManager = GameManager.Instance;
			rb = GetComponent<Rigidbody> ();
			rb.isKinematic = true;
		}

		void Update ()
		{
			if (gameManager.playerStatus == GameManager.PlayerState.Ready
			   && Input.GetButton ("Horizontal")) {
				float h = Input.GetAxis ("Horizontal");
				Vector3 movement = new Vector3 (h, 0f, 0f);
				transform.position += movement * 10f * Time.deltaTime;
			}

			if (gameManager.playerStatus == GameManager.PlayerState.Ready
			   && Input.GetButtonDown ("Jump")) {
				rb.isKinematic = false;
				rb.AddForce (transform.forward * shotPower, ForceMode.Impulse);
				gameManager.playerStatus = GameManager.PlayerState.Shot;
			}
		}
	}
}