using UnityEngine;
using System.Collections;

namespace UnityCamp_study0426
{
	public class BallController : MonoBehaviour
	{
		public float shotPower = 70f;
		private Rigidbody rb;
		//private GameManager gameManager;
		private bool shot = false;

		void Start ()
		{
			//gameManager = GameManager.Instance;
			rb = GetComponent<Rigidbody> ();
			rb.isKinematic = true;
		}

		void Update ()
		{
			if (!shot
			   && Input.GetButton ("Horizontal")) {
				float h = Input.GetAxis ("Horizontal");
				Vector3 movement = new Vector3 (h, 0f, 0f);
				transform.position += movement * 10f * Time.deltaTime;
			}

			if (!shot
			   && Input.GetButtonDown ("Jump")) {
				rb.isKinematic = false;
				rb.AddForce (transform.forward * shotPower, ForceMode.Impulse);
				//gameManager.playerStatus = GameManager.PlayerState.Shot;
				shot = true;
			}
		}
	}
}