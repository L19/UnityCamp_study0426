using UnityEngine;
using System.Collections;

namespace UnityCamp_study0426
{
	public class GameManager : Singleton<GameManager>
	{
		public int score;

		public enum PlayerState
		{
			Ready,
			Shot,
			Result
		}

		public PlayerState playerStatus;

		public void RetryGame ()
		{
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}