namespace UnityEngine.Rendering.Universal
{
    partial class ScriptableRenderer
    {
        protected void DequeuePass(ScriptableRenderPass pass)
        {
            if (m_ActiveRenderPassQueue.Contains(pass))
                m_ActiveRenderPassQueue.Remove(pass);
        }
    }
}