using PathCreation;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public float speed = 1f;

    private PathCreator _pathCreator;
    private float _distanceTravelled;

    private void Start()
    {
        _pathCreator = FindObjectOfType<PathCreator>();
        _distanceTravelled = 0;
    }

    void Update()
    {
        _distanceTravelled += speed * Time.deltaTime * TigerSpeedManager.GetSpeed();
        transform.position = _pathCreator.path.GetPointAtDistance(_distanceTravelled);
        transform.rotation = _pathCreator.path.GetRotationAtDistance(_distanceTravelled);
    }
}
