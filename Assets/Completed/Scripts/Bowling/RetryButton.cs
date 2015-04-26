using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace UnityCamp_study0426.Completed
{
	public class RetryButton : MonoBehaviour
	{
		private Button button;
		private GameManager gameManager;

		void Start ()
		{
			button = GetComponent<Button> ();
			button.enabled = false;
			gameManager = GameManager.Instance;
		}

		void Update ()
		{
			if (gameManager.playerStatus == GameManager.PlayerState.Result) {
				button.enabled = true;
			}
		}
	}
}