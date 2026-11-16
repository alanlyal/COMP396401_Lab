using UnityEngine.InputSystem;
using UnityEngine;

public class Cannon : MonoBehaviour
{
  
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private GameObject _canonBallPrefab;
    [SerializeField] private float _forceMultiplier;
 
    private void Update()
    {
        //TODO: objectpool for Instantiation and reusability of objects and cooldown for shooting
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            var canonBall = Instantiate(_canonBallPrefab, _spawnPoint.position, Quaternion.identity).GetComponent<Rigidbody>();
            canonBall.GetComponent<Rigidbody>().AddForce(_spawnPoint.forward * _forceMultiplier, ForceMode.Impulse);
            Destroy(canonBall.gameObject, 3f);
        }
    }
}

