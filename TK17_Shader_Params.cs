namespace TK17
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.Rendering;

	[ExecuteInEditMode]
	public class TK17_ShaderParams : MonoBehaviour
	{
		[System.Serializable]
		public class StringBoolPair
		{
			public string key;
			public bool value;
		}

		[System.Serializable]
		public class StringFloatPair
		{
			public string key;
			public float value;
		}

		public List<StringFloatPair> floatparams = new List<StringFloatPair>();

		public void AssignParams(ref Material mat)
		{
			for (int i = 0; i < floatparams.Count; ++i)
			{
				mat.SetFloat(floatparams[i].key, floatparams[i].value);
			}
		}
	}
}