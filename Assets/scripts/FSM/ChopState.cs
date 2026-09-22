using UnityEngine;
using UnityEngine.AI;
namespace Core.FSM
{
    public class ChopState : BaseState// custom state 1
    {
        public ChopState(MeshRenderer renderer, NavMeshAgent agent) : base(renderer, agent)
        {
        }
        public override void Enter()
        {
            meshRenderer.material.color = Color.brown;
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
