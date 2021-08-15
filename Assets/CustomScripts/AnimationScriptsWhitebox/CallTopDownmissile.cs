using UnityEngine;
using UnityEngine.Events;
namespace Gamekit2D
{
    public class CallTopDownmissile : SceneLinkedSMB<Alibaba>
    {
        public override void OnSLStateEnter (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {

        }

        public override void OnSLStateNoTransitionUpdate (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
        }
        
        public override void OnSLStateExit (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
          m_MonoBehaviour.TopDownSandMissile();
        }
    }
}