using UnityEngine;

public class EventTimer : MonoBehaviour
{
    [SerializeField] private VoidEventChannel _harvestEvent;
    private float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5f)
        {
            if (_harvestEvent != null) _harvestEvent.RaisedEvent();
            timer = 0;
        }
    }
}