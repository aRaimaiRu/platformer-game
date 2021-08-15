using UnityEngine;

namespace Gamekit2D
{
    public class Walking : SceneLinkedSMB<Alibaba>
    {
        private float time;
        public float AnimatorDuration;
   
        public override void OnSLStateEnter (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            // player = GameObject.FindGameObjectWithTag("Player").transform;
            // rb = animator.GetComponent<Rigidbody2D>();
            time=0;
        }

        public override void OnSLStateNoTransitionUpdate (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            time += Time.deltaTime;
            m_MonoBehaviour.SlashAttack(time/AnimatorDuration);
        }
        
        public override void OnSLStateExit (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
          
        }
    }
}