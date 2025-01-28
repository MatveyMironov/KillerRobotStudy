using System;
using System.Collections;
using UnityEngine;

namespace LocomotionSystem
{
    public class PawMover : MonoBehaviour
    {
        [SerializeField] private Transform paw;
        [SerializeField] private float speed;

        public event Action OnPawMoved;

        public void StartMovingPaw(float distance)
        {
            StartCoroutine(MovingPaw(distance));
        }

        private IEnumerator MovingPaw(float distance)
        {
            Vector3 startPosition = paw.position;
            Vector3 targetPosition = startPosition + Vector3.forward * distance;

            while (paw.position != targetPosition)
            {
                yield return null;

                paw.position = Vector3.MoveTowards(paw.position, targetPosition, speed * Time.deltaTime);
            }

            OnPawMoved?.Invoke();
        }
    }
}