namespace TK17
{
	using UnityEngine;

	public struct ShaderParamChangeEventArgs
	{
		public TK17_ShaderParams shaderparams;
	}

    public delegate void ShaderParamsChangedEventHandler(object sender, ShaderParamChangeEventArgs e);

    public class TK17_Events : MonoBehaviour
	{

		public event ShaderParamsChangedEventHandler ShaderParamsChanged;

        public virtual void OnShaderParamChanged(ShaderParamChangeEventArgs e)
		{
			if (ShaderParamsChanged != null)
				ShaderParamsChanged(this, e);
		}


	}
}