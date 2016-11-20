Shader "Custom/Water_Low_Poly_Basic" 
{
	Properties 
	{
		_Amount ("Opacity", Range(-1,1)) = 0.0
		_Color ("Color", Color) = (1,1,1,1)
		_Glossiness ("Glossiness", Range(0,1)) = 0.5
	}
	SubShader 
	{
		Tags { "Queue"="Transparent" "RenderType"="Transparent" "ForceNoShadowCasting"="True" "IgnoreProjector" = "True"}
		LOD 200
		
		ZWrite Off
		
		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		//#pragma surface surf Standard fullforwardshadows

		#pragma surface surf Standard alpha noforwardadd
		// Use shader model 3.0 target, to get nicer looking lighting
		//#pragma target 3.0

		struct Input 
		{
			fixed3 color : COLOR;
		};

		half _Glossiness;
		float _Amount;
		fixed3 _Color;
				
		void surf (Input IN, inout SurfaceOutputStandard o) 
		{
			o.Albedo = _Color;
			o.Smoothness = _Glossiness;
			o.Alpha  = _Amount;
		}

		ENDCG
	}
	FallBack "Transparent/VertexLit"
}
