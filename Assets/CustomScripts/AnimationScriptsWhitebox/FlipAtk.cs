using UnityEngine;

namespace Gamekit2D
{
    public class FlipAtk : SceneLinkedSMB<Alibaba>
    {
        private Transform tr;
        public override void OnSLStateEnter (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            // player = GameObject.FindGameObjectWithTag("Player").transform;
            // rb = animator.GetComponent<Rigidbody2D>();
            tr = animator.GetComponent<Transform>();
            tr.localScale = new Vector3(-tr.localScale.x,tr.localScale.y,tr.localScale.z);

       }

        public override void OnSLStateNoTransitionUpdate (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            m_MonoBehaviour.FlipSlashAttack(1.0f);
        }
        
        public override void OnSLStateExit (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            tr.localScale = new Vector3(-tr.localScale.x,tr.localScale.y,tr.localScale.z);
        }
    }
}