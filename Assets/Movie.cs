using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Movie : MonoBehaviour
{
    private NavMeshAgent agent;
    private Vector3[] points;
    private int currentPoint = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        points = new Vector3[] {new Vector3(-5, 0, -5), new Vector3(-5, 0, 5), new Vector3(5, 0, 5), new Vector3(5, 0, -5) };
        agent.destination = points[currentPoint];

    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance <= 0.1)
        {
            currentPoint++;
            if (currentPoint == points.Length)
            {
                currentPoint = 0;
            }
            agent.destination = points[currentPoint];
        }
    }
}
