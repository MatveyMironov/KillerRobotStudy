using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawMover : MonoBehaviour
{
    [SerializeField] private Transform paw;
    [SerializeField] private float speed;
    [SerializeField] private float distance;

    public event Action OnPawMoved;

    public void StartMovingPaw()
    {
        StartCoroutine(MovingPaw());
    }

    private IEnumerator MovingPaw()
    {
        Vector3 startPosition = paw.position;
        Vector3 targetPosition = startPosition + (Vector3.forward * distance);

        while (paw.position != targetPosition)
        {
            yield return null;

            paw.position = Vector3.MoveTowards(paw.position, targetPosition, speed * Time.deltaTime);
        }

        OnPawMoved?.Invoke();
    }
}
