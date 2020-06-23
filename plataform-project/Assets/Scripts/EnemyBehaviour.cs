using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] private float velocity;
    [SerializeField] private Transform target;

    private MovimentController movimentC;
    private void Start()
    {
        movimentC = GetComponent<MovimentController>();
    }
    private void Update()
    {
        FollowThePlayer();
    }

    void FollowThePlayer()
    {
        float followPos = (target.position.x > this.transform.position.x) ? velocity : -velocity;
        movimentC.Move(followPos);
    }
}
