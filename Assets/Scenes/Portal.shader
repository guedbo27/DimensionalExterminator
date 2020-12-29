Shader "Custom/Portal"
{
	Properties
    {
		_Integer("Layer", int) = 0
    }

	SubShader{
		Zwrite off
		ColorMask 0
		Cull off

		Stencil{
			Ref [_Integer]
			Comp Greater
			Pass replace
		}

		Pass{
		
		}
	}
}