using System;
using Unity.Behavior;
using UnityEngine;

[Serializable, Unity.Properties.GeneratePropertyBag]
[Condition(name: "BoolEvent", story: "[event] received", category: "Conditions", id: "d7e1abedc0e6f206863202acb2f20c07")]
public partial class BoolEventCondition : Condition
{
    [SerializeReference] public BlackboardVariable<BoolEventChannel> Event;
    private bool status = false;
    public override bool IsTrue()
    {
        Debug.Log($"bool condition isTrue -> {status}");
        return status;
    }

    public override void OnStart()
    {
        Debug.Log("bool condition onStart");
        Event.Value.OnEventRaised += value => status = value;
    }

    public override void OnEnd()
    {
        Debug.Log("bool condition onEnd");
        Event.Value.OnEventRaised -= value => status = value;
    }
}
