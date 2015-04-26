using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace UnityCamp_study0426
{
	public class StrikeView : MonoBehaviour
	{
		private Text text;
		private GameManager gameManager;

		void Start ()
		{
			text = GetComponent<Text> ();
			text.enabled = false;
			gameManager = GameManager.Instance;
		}

		void Update ()
		{
			if (gameManager.score == 10f) {
				text.enabled = true;
			}
		}
	}
}