namespace TK17
{
	using UnityEngine;
	using System.Collections;

	public struct ShaderParamChangeEventArgs
	{
		public TK17_ShaderParams shaderparams;
	}


	public class TK17_Events : MonoBehaviour
	{

		public event ShaderParamChangeEventArgs ShaderParamsChanged;

		public virtual void OnShaderParamChanged(ShaderParamChangeEventArgs e)
		{
			if (ShaderParamsChanged != null)
				ShaderParamsChanged(this, e);
		}


	}
}