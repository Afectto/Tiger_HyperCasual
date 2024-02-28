using UnityEngine;

public abstract class Building : MonoBehaviour
{
    public abstract void OnTriggerEnter(Collider other);
}