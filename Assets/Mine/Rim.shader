Shader "Unlit/Rim"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
		_RimWidth("RIM Width", Range(0.5, 8.0)) = 3.0
	}
	SubShader
	{
		Tags { "RenderType"="Opaque" }

		CGPROGRAM
		    	#pragma surface surf Lambert
		    	struct Input {
		    	    float2 uv_MainTex;
		    	    float3 viewDir;
		    	};
		    	
		    	sampler2D _MainTex;
		    	float _RimWidth;
		    	
		    	void surf(Input IN, inout SurfaceOutput o){
		    	    o.Albedo = tex2D(_MainTex, IN.uv_MainTex).rgb;
		    	    half rim = 1.0 -saturate(dot(normalize(IN.viewDir), o.Normal));
		    	    half rim2 = pow(rim, _RimWidth);
		    	    half rim3;
		    	    if (rim2 < 0.5)rim3 = 1.0; else rim3 = 0.0;
		    	    o.Albedo *= rim3; 
		    	} 
		ENDCG
	}
	FallBack "Diffuse"
}
