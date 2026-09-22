
using UnityEngine;
using UnityEngine.AI;

namespace Core.FSM
{
    public class HarvestState : BaseState
    {
        private GameObject HarvestingPlot;
        //private NavMeshAgent agent;
        public HarvestState(MeshRenderer renderer, NavMeshAgent agent) : base(renderer, agent)
        { 
            
        }
        public override void Enter()
        {
            Debug.Log("HarvestState.Enter()");
            meshRenderer.material.color = Color.green;

            HarvestingPlot = GameObject.FindGameObjectWithTag("HarvestingPlot");

            agent.SetDestination(HarvestingPlot.transform.position);
            agent.isStopped = false;
        }
        public override void Update()
        {
           base.Update();
        }
        public override void Exit()
        {
            base.Exit();
            HarvestingPlot = null;
        }
    }

}   
