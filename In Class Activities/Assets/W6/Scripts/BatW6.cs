using System.Security.Cryptography;
using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    private Transform _playerTreansform;

    private void Update()
    {
        Transform.position = Vector3.MoveTowards(
            transform.position,
            _playerTransform.position,
            _speed

            
            );

    }

}
