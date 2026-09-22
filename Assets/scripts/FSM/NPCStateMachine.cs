using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;
namespace Core.FSM
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class NPCStateMachine : MonoBehaviour
    {
        StateMachine stateMachine;
        private void Awake()
        {
            stateMachine = new StateMachine();
            MeshRenderer renderer = GetComponent<MeshRenderer>();
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            PatrolState patrol = new PatrolState(renderer, new GameObject[2], agent);
            HarvestState harvest = new HarvestState(renderer, agent);
            SharpState sharp = new SharpState(renderer, agent);
            ChopState chop = new ChopState(renderer, agent);
            RestState rest = new RestState(renderer, agent);
            stateMachine.AddTransition(rest, patrol, new FuncPredicate(() => Keyboard.current.pKey.wasPressedThisFrame));
            stateMachine.AddTransition(rest, harvest, new FuncPredicate(() => Keyboard.current.hKey.wasPressedThisFrame));
            stateMachine.AddTransition(harvest, rest, new FuncPredicate(() => Keyboard.current.rKey.wasPressedThisFrame));
            stateMachine.AddTransition(patrol, rest, new FuncPredicate(() => Keyboard.current.rKey.wasPressedThisFrame));
            //challenge stuff
            stateMachine.AddTransition(rest, sharp, new FuncPredicate(() => Keyboard.current.bKey.wasPressedThisFrame));// rest to sharp
            stateMachine.AddTransition(sharp, rest,new FuncPredicate(() => Keyboard.current.rKey.wasPressedThisFrame));// sharp to rest
            stateMachine.AddTransition(rest, chop,new FuncPredicate(() => Keyboard.current.cKey.wasPressedThisFrame));// rest to chop
            stateMachine.AddTransition(chop, rest,new FuncPredicate(() => Keyboard.current.rKey.wasPressedThisFrame));// chop to rest
            stateMachine.SetState(rest);
        }
        private void Update()
        {
            stateMachine.Update();
        }
    }
}   
