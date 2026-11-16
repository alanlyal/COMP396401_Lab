using System;
using UnityEngine;

public class FarmerFactory : MonoBehaviour, IThemeFactory
{
    [SerializeField] private GameObject _farmerPrefab;
    public IEntity CreateEntity()
    {
        Instantiate(_farmerPrefab, gameObject.transform.position + new Vector3(0f, 1f, 0), Quaternion.identity);
        return null;
    }
    public IStateMachine CreateStateMachine()
    {
        Debug.Log("Farmer State Machine Created");
        return null;
    }
    public ITask CreateTask()
    {
        Debug.Log("Farmer Task Created");
        return null;
    }
}
