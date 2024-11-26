Shader "Custom/HeightHeatMap"
{
    Properties
    {
        _MinHeight("Min Height", Float) = 0
        _MaxHeight("Max Height", Float) = 10
        _Color1("Low Height Color", Color) = (0, 0, 1, 1) // Blue
        _Color2("High Height Color", Color) = (1, 0, 0, 1) // Red
        _TimeSpeed("Time Speed", Float) = 1.0
    }
        SubShader
    {
        Tags { "RenderType" = "Opaque" }
        LOD 200

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            struct appdata
            {
                float4 vertex : POSITION;
            };

            struct v2f
            {
                float4 pos : POSITION;
                float height : TEXCOORD0;
            };

            float _MinHeight;
            float _MaxHeight;
            float4 _Color1;
            float4 _Color2;
            float _TimeSpeed;

            v2f vert(appdata v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.height = (v.vertex.y - _MinHeight) / (_MaxHeight - _MinHeight);
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                float heightFactor = saturate(i.height);
                float timeFactor = 0.5 + 0.5 * sin(_TimeSpeed * _Time.y);
                return lerp(_Color1, _Color2, heightFactor * timeFactor);
            }
            ENDCG
        }
    }
}
