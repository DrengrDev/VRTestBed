Shader "Custom/FlowingPuddle"
{
    Properties
    {
        _AlbedoTex ("Abledo (RGB)", 2D) = "white" {}
		[NoScaleOffset] _BumpTex ("Normal Map", 2D) = "bump" {}
		[NoScaleOffset] _HeightTex ("Height Map", 2D) = "black" {}
		[NoScaleOffset] _SpecTex("Specular Map", 2D) = "black" {}

		_AlbedoTex2 ("Albedo 2 (RGB)", 2D) = "white" {}
		[NoScaleOffset] _BumpTex2 ("Normal Map 2", 2D) = "bump" {}
		[NoScaleOffset] _heightTex2 ("Height Map 2", 2D) = "black" {}
		[NoScaleOffset] _SpecTex2("Specular Map 2", 2D) = "black" {}

		_WaterBump ("Water Bump", 2D) = "bump" {}
		_Flow ("Flow (X, Y, Cycle Time, Cycle Speed", Vector) = (1,1,0.1,1)
		
        _Contrast ("Height Blend", Float) = 1
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0
		_FloodLevel("Flood Level", Float) = 1
		_WaterOpacity ("Water Opacity", Range(0,1)) = 1
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        #pragma surface surf StandardSpecular fullforwardshadows
        #pragma target 3.0

		half _Glossiness;
		half _Metallic;
		half _Contrast;
		half _FloodLevel;
		half _WaterOpacity;
		sampler2D _AlbedoTex;
		sampler2D _BumpTex;
		sampler2D _HeightTex;
		sampler2D _SpecTex;
		sampler2D _AlbedoTex2;
		sampler2D _BumpTex2;
		sampler2D _HeightTex2;
		sampler2D _SpecTex2;
		sampler2D _FlowMap;
		sampler2D _WaterBump;
		float4 _Flow;

        struct Input
        {
			float2 uv_AlbedoTex;
			float2 uv_AlbedoTex2;
			float4 color : COLOR;
        };

        void surf (Input IN, inout SurfaceOutputStandardSpecular o)
        {
			float h = tex2D(_HeightTex, IN.uv_AlbedoTex);
			float h2 = tex2D(_HeightTex2, IN.uv_AlbedoTex2);
			float blend = saturate(h2*h2 + IN.color.a*_Contrast - h * h*_Contrast);
			h = lerp(h, h2, blend);

			float wet = IN.color.b;
			wet = saturate(wet*wet*_Contrast + wet *_FloodLevel - h*h*_Contrast);

			float2 flow = IN.color.rg;
			flow = flow * -2 + 1;
			flow *= _Flow.xy;
			float flowStrength = length(flow);

			float halfCycle = _Flow.z * 0.5;
			float phase1 = fmod(_Time.x*_Flow.w, _Flow.z);
			float phase2 = fmod(_Time.x*_Flow.w + halfCycle, _Flow.z);
			float flowBlend = abs(phase1 - halfCycle) / halfCycle;

			float3 w1 = UnpackNormal(tex2D(_WaterBump, IN.uv_AlbedoTex + flow * phase1));
			float3 w2 = UnpackNormal(tex2D(_WaterBump, IN.uv_AlbedoTex + flow * phase2));
			float3 waterNorm = lerp(float3(0, 0, 1), lerp(w1, w2, flowBlend), flowStrength*wet);

			fixed4 c = tex2D(_AlbedoTex, IN.uv_AlbedoTex);
			fixed4 c2 = tex2D(_AlbedoTex2, IN.uv_AlbedoTex2);
			c = lerp(c, c2, blend);
			c.rgb = lerp(c.rgb, c.rgb*(1- _WaterOpacity), wet*_WaterOpacity);

			float3 n = UnpackNormal(tex2D(_BumpTex, IN.uv_AlbedoTex));
			float3 n2 = UnpackNormal(tex2D(_BumpTex2, IN.uv_AlbedoTex2));
			n = normalize(lerp(n, n2, blend));
			n = lerp(n, waterNorm, wet*wet);

			fixed4 s = tex2D(_SpecTex, IN.uv_AlbedoTex);
			fixed4 s2 = tex2D(_SpecTex2, IN.uv_AlbedoTex2);
			s = lerp(s, s2, blend);
			s.rgb = lerp(s.rgb, 0.7, wet);
			s.a = lerp(s.a, 1, wet);

            o.Albedo = c.rgb;
			o.Alpha = c.a;
			o.Normal = n;

			o.Specular = s.rgb;
			o.Smoothness = s.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
