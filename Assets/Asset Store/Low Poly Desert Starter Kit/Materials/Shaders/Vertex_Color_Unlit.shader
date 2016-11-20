﻿Shader "Custom/Vertex_Color_Unlit"
{
	Properties
	{
	 	_Color ("Main Color", Color) = (1,1,1,1)
	}
	SubShader
	{
		Tags { "RenderType"="Opaque" }
		LOD 100

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
            
            #include "UnityCG.cginc"

			struct appdata
			{
				 float4 vertex : POSITION;
            	 fixed4 color : COLOR;
			};

			struct v2f
			{
				  float4 vertex : SV_POSITION;
            	  fixed4 color : COLOR;
			};
		
			fixed4 _Color;
			
			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);				
	            o.color = v.color * _Color;	
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{	        
				return i.color;
			}
			
			ENDCG
		}
	}
}
