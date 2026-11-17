using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision other)
    {
        //TODO improve collision detection from enemy perspective
        if (other.gameObject.CompareTag("CanonBall"))
        {
            Destroy(gameObject);
        }
    }
}
