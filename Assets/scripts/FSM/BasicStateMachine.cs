using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.InputSystem;
[System.Serializable]
public enum BasicStates
{
    Patrolling, Harvesting, Fishing ,Resting, Shopping, Planting, Herding, Cooking, Chopping, Sharpening
        // 2 new states is chopping and swimming
}
[RequireComponent(typeof(MeshRenderer))]
public class BasicStateMachine : MonoBehaviour
{
    [SerializeField] private BasicStates currentStates;
    private MeshRenderer meshRenderer;
    private void Awake()
    {
        currentStates = BasicStates.Resting;
        meshRenderer = GetComponent<MeshRenderer>();
    }
    public void ChangeState(BasicStates newState)
    {
        if (currentStates == newState) return;
        currentStates = newState;
    }
    private void Update()
    {
        switch (currentStates) 
        {
            case BasicStates.Resting:
                meshRenderer.material.color = Color.cyan;
                break; 
            case BasicStates.Harvesting:
                meshRenderer.material.color = Color.green;
                break;
            case BasicStates.Patrolling:
                meshRenderer.material.color = Color.yellow;
                break;
            case BasicStates.Shopping:
                break;
            case BasicStates.Planting:
                break;
            case BasicStates.Herding:
                break;
            case BasicStates.Cooking:
                break;
            case BasicStates.Fishing:
                break;
            //challenge create 2 extra states
            case BasicStates.Chopping: // like chopping wood
                meshRenderer.material.color = Color.brown;
                break;
            case BasicStates.Sharpening: // sharpening tools
                meshRenderer.material.color = Color.purple;
                break;
        }
        if (Keyboard.current.pKey.wasPressedThisFrame)
        {
            ChangeState(BasicStates.Patrolling);
        }
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            ChangeState(BasicStates.Resting);
        }
        if (Keyboard.current.hKey.wasPressedThisFrame)
        {
            ChangeState(BasicStates.Harvesting);
        }
        if (Keyboard.current.cKey.wasPressedThisFrame)// press c to chop wood
        {
            ChangeState(BasicStates.Chopping);
        }
        if (Keyboard.current.bKey.wasPressedThisFrame) // press b to sharpen tools
        {
            ChangeState(BasicStates.Sharpening);
        }
    }
}
