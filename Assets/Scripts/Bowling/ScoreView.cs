using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace UnityCamp_study0426
{
	public class ScoreView : MonoBehaviour
	{
		private Text scoreText;
		private GameManager gameManager;

		void Start ()
		{
			scoreText = GetComponent<Text> ();
			gameManager = GameManager.Instance;
		}

		void Update ()
		{
			scoreText.text = "Score: " + gameManager.score;
		}
	}
}