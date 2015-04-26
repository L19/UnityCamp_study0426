using UnityEngine;
using System.Collections;

namespace UnityCamp_study0426
{
	public class Pin : MonoBehaviour
	{
		//		private GameManager gameManager;
		private bool isDead = false;

		void Start ()
		{
			//	gameManager = GameManager.Instance;
		}

		void Update ()
		{
			Ray ray = new Ray (transform.position, -1f * transform.up);

			if (!Physics.Raycast (ray, 1.5f, 1 << LayerMask.NameToLayer ("Ground")) && !isDead) {
				//	gameManager.score += 1;
				isDead = true;
				Destroy (gameObject, 3f);
			}
		}
	}
}