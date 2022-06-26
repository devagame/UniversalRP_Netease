namespace UnityEngine.Rendering.Universal
{
    public partial class PostProcessData
    {
        public partial class ShaderResources
        {
            [Reload("Shaders/PostProcessing/AMDFSR/EdgeAdaptiveSpatialUpsampling.compute")]
            public ComputeShader easuCS;

            [Reload("Shaders/PostProcessing/AMDFSR/RobustContrastAdaptiveSharpen.compute")]
            public ComputeShader rcasCS;
        }
    }
}