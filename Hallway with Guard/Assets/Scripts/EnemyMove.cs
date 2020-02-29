using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    private GameObject Point1;
    private GameObject Point2;
    private GameObject Point3;
    private GameObject Point4;
    private GameObject Point5;
    private GameObject Point6;

    private GameObject player;

    private DebugLOS debugLOS;
    public Transform[] points;
    private int thePoint = 0;

    [SerializeField]
    private Transform _destination;

    private NavMeshAgent _navMeshAgent;

    private void Start()
    {
        Point1 = GameObject.FindWithTag("Point1");
        Point2 = GameObject.FindWithTag("Point2");
        Point3 = GameObject.FindWithTag("Point3");
        Point4 = GameObject.FindWithTag("Point4");
        Point5 = GameObject.FindWithTag("Point5");
        Point6 = GameObject.FindWithTag("Point6");
        GameObject[] objectArray = { Point1, Point2, Point3, Point4, Point5, Point6 };

        player = GameObject.FindWithTag("Player");
        _destination = player.transform;

        GameObject debugLOSObject = GameObject.FindWithTag("Enemy");
        if (debugLOSObject != null)
        {
            debugLOS = debugLOSObject.GetComponent<DebugLOS>();
        }
        if (debugLOSObject == null)
        {
            Debug.Log("hehe haha oops");
        }

        for (int i = 0; i < objectArray.Length; i++)
        {
            points[i] = objectArray[i].transform;
        }

        _navMeshAgent = GetComponent<NavMeshAgent>();
        NextPoint();
    }

    private void NextPoint()
    {
        if (points.Length == 0)
            return;
        _navMeshAgent.destination = points[thePoint].position;
        thePoint = (thePoint + 1) % points.Length;
    }

    private void Update()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();

        if (debugLOS.sight == 1)
        {
            if (!_navMeshAgent.pathPending && _navMeshAgent.remainingDistance < 0.5f)
                NextPoint();
        }

        if (debugLOS.sight == 2)
        {
            SetDestination();
        }
    }

    private void SetDestination()
    {
        if (_destination != null)
        {
            Vector3 targetVector = _destination.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }
    }
}