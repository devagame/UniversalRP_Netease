namespace UnityEngine.Rendering.Universal
{
    public partial class UniversalAdditionalCameraData
    {
        public enum AMDFSR
        {
            Disabled = -1,
            UltraQuality = 0,
            Quality,
            Balanced,
            Performance
        }

        [SerializeField] 
        private AMDFSR m_AMDFSR = AMDFSR.Disabled;

        public AMDFSR amdFSR
        {
            get => m_AMDFSR;
            set => m_AMDFSR = value;
        }
        
        [SerializeField] 
        private ColorSpace m_ColorSpaceUsage = ColorSpace.Linear;

        public ColorSpace ColorSpaceUsage
        {
            get => m_ColorSpaceUsage;
            set => m_ColorSpaceUsage = value;
        }
    }
}