﻿using UnityEngine;
using System.Collections;

namespace UnityCamp_study0426.Completed
{
	public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		protected static T instance;

		public static T Instance {
			get {
				if (instance == null) {
					instance = (T)FindObjectOfType (typeof(T));

					if (instance == null) {
						Debug.LogError ("An instance of " + typeof(T) +
						" is needed in the scene, but there is none.");
					}
				}

				return instance;
			}
		}

		protected void Awake ()
		{
			CheckInstance ();
		}

		protected bool CheckInstance ()
		{
			if (this == Instance) {
				return true;
			} else {
				Destroy (this);
				return false;
			}
		}
	}
}