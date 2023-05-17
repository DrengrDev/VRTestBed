Shader "Unlit/FlowShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
		_FlowMap ("Flow Map", 2D) = "grey" {}
		_Flow("Flow (X, Y, Cycle Time, Cycle Speed", Vector) = (1,1,0.1,1)
    }
    SubShader
    {
        Tags { 
			"RenderType"="Opaque"
			"Queue" = "Transparent"
			"CanUseSpriteAtlas" = "True"
			"IgnoreProjectore" = "True"
			"PreviewType" = "Plane"
		}
        Cull Off
		Lighting Off
		ZWrite Off
		Fog {Mode Off}
		Blend SrcAlpha OneMinusSrcAlpha

        Pass
        {
            CGPROGRAM
			#pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
				float2 flowUV : TEXCOORD1;
				float4 color : COLOR;
            };

            struct v2f
            {
				float4 vertex : SV_POSITION;
                float2 uv : TEXCOORD0;
				float2 flowUV : TEXCOORD1;
				float4 color : COLOR;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
			sampler2D _FlowMap;
			float4 _FlowMap_ST;
			float4 _Flow;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				o.flowUV = TRANSFORM_TEX(v.flowUV, _FlowMap);
				o.color = v.color;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
				float2 flow = tex2D(_FlowMap, i.flowUV);
				flow = flow * -2 + 1;
				flow *= _Flow.xy;

				float halfCycle = _Flow.z * 0.5;
				float phase1 = fmod(_Time.x*_Flow.w, _Flow.z);
				float phase2 = fmod(_Time.x*_Flow.w + halfCycle, _Flow.z);
				float blend = abs(phase1 - halfCycle) / halfCycle;

				fixed4 c1 = tex2D(_MainTex, i.uv + flow * phase1);
				fixed4 c2 = tex2D(_MainTex, i.uv + flow * phase2);
				fixed col = lerp(c1, c2, blend);
				return col;
            }
            ENDCG
        }
    }
}
