using UnityEngine;

namespace UnityEditor.Rendering.Universal
{
    internal partial class UniversalRenderPipelineCameraEditor
    {
        private partial class StylesEx
        {
            public static GUIContent AMDFSR = EditorGUIUtility.TrTextContent("AMD FSR 1.0",
                "AMD FidelityFX Super Resolution 1.0 is a cutting edge super-optimized spatial upscaling technology that produces impressive image quality at fast framerates.");
        }

        private SerializedProperty m_AdditionalCameraDataRenderAMDFSR;
        private SerializedProperty colorSpaceUsage;
        private SerializedProperty renderPostProcessing;

        private void DrawRenderSettingsEx()
        {
            EditorGUILayout.PropertyField(colorSpaceUsage);
        }

        private void InitEx(SerializedObject m_AdditionalCameraDataSO)
        {
            m_AdditionalCameraDataRenderAMDFSR = m_AdditionalCameraDataSO.FindProperty("m_AMDFSR");
            colorSpaceUsage = m_AdditionalCameraDataSO.FindProperty("m_ColorSpaceUsage");
            renderPostProcessing = m_AdditionalCameraDataSO.FindProperty("m_RenderPostProcessing");
        }

        private void DrawPostProcessingEx()
        {
            //if (renderPostProcessing.boolValue)
            //    EditorGUILayout.PropertyField(m_AdditionalCameraDataRenderAMDFSR, StylesEx.AMDFSR);
        }

        public static void DrawRenderSettingsEx(UniversalRenderPipelineSerializedCamera cam, Editor owner)
        {
            var e = owner as UniversalRenderPipelineCameraEditor;
            if (e == null)
                return;

            e.DrawRenderSettingsEx();
        }

        public static void DrawPostProcessingEx(Editor owner)
        {
            var e = owner as UniversalRenderPipelineCameraEditor;
            if (e == null)
                return;

            e.DrawPostProcessingEx();
        }
    }
}