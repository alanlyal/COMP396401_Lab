
using UnityEngine;
using UnityEngine.AI;

namespace Core.FSM
{
    public class SharpState : BaseState// custime state 2
    {
        public SharpState(MeshRenderer renderer, NavMeshAgent agent) : base(renderer, agent)
        {
        }
        public override void Enter()
        {
            meshRenderer.material.color = Color.purple;
        }
        public override void Update()
        {

        }
        public override void Exit()
        {
            base.Exit();
        }
    }

}   
