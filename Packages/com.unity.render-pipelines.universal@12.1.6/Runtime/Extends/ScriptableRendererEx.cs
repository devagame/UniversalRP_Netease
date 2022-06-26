namespace UnityEngine.Rendering.Universal
{
    partial class ScriptableRenderer
    {
        public void DequeuePass(ScriptableRenderPass pass)
        {
            if (m_ActiveRenderPassQueue.Contains(pass))
                m_ActiveRenderPassQueue.Remove(pass);
        }
    }
}