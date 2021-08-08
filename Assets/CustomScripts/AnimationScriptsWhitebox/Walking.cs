using UnityEngine;

namespace Gamekit2D
{
    public class Walking : SceneLinkedSMB<Alibaba>
    {
  
        public override void OnSLStateEnter (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            // player = GameObject.FindGameObjectWithTag("Player").transform;
            // rb = animator.GetComponent<Rigidbody2D>();

        }

        public override void OnSLStateNoTransitionUpdate (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            m_MonoBehaviour.SlashAttack(1.0f);
        }
        
        public override void OnSLStateExit (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
           
        }
    }
}