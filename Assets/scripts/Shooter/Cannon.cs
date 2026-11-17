using UnityEngine.InputSystem;
using UnityEngine;


public class Cannon : MonoBehaviour
{
  
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private GameObject _canonBallPrefab;
    [SerializeField] private float _forceMultiplier;
    [SerializeField] private float _cooldown = 0.5f;
    private float _canShoot;


    private void Update()
    {
  
        if (Mouse.current.leftButton.wasPressedThisFrame && Time.time >= _canShoot)
        {
            _canShoot = Time.time + _cooldown;
            var canonBall = Instantiate(_canonBallPrefab, _spawnPoint.position, Quaternion.identity);
            canonBall.GetOrAddComponent<CanonBall>();
            canonBall.GetComponent<Rigidbody>().AddForce(_spawnPoint.forward * _forceMultiplier, ForceMode.Impulse);
            Destroy(canonBall, 3f);
        }
    }
    
}
