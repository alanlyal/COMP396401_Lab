using UnityEngine;
using UnityEngine.Events;   

[CreateAssetMenu(fileName = "VoidEventChannel", menuName = "Events/VoidEventChannel")]
public class VoidEventChannel : ScriptableObject
{
    public event UnityAction OnEventRaised; //this is called by anyone that needs to dispatch this event
    public void RaisedEvent()
    {
        OnEventRaised?.Invoke();
    }
}
public class PlayerEventChannel : GenericEventChannel<Player>
{

}
public struct Player
{
    public string name;
    public int level;
    public float currentHealth;
    public float maxHealth;
    

}