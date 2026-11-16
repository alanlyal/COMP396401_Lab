using UnityEngine;
using UnityEngine.Events;

public abstract class GenericEventChannel<T> : ScriptableObject
{
    public event UnityAction<T> OnEventRaised;

    public void RaisedEvent()
    {
        OnEventRaised?.Invoke(default);
    }

    public void RaiseEvent(T value)
    {
        OnEventRaised?.Invoke(value);
    }
}