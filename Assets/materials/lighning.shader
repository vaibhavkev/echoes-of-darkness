Shader "Custom/lighning"
{
    Properties {
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _FlashIntensity ("Flash Intensity", Range(0, 1)) = 0
        _FlashColor ("Flash Color", Color) = (1, 1, 1, 1)
    }
    SubShader {
        Tags { "RenderType"="Opaque" }
        LOD 200

        Pass {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata_t {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float _FlashIntensity;
            float4 _FlashColor;

            v2f vert (appdata_t v) {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            half4 frag (v2f i) : SV_Target {
                half4 col = tex2D(_MainTex, i.uv);

                // Apply the flash effect based on intensity
                col.rgb += _FlashColor.rgb * _FlashIntensity;

                return col;
            }
            ENDCG
        }
    }
}