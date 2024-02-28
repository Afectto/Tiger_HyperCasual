
using System.Collections;
using UnityEngine;

public class TigerSpeedManager : MonoBehaviour
{
    private static float speedMultiplier = 1;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(IncreasedValueSpeed(Random.Range(1.5f, 2f)));
        }
    }

    private IEnumerator IncreasedValueSpeed(float value)
    {
        IncreasedSpeed(value);
        yield return new WaitForSeconds(0.5f);
        ReduceSpeed(value);
    }

    public static void IncreasedSpeed(float value)
    {
        speedMultiplier *= value;
    }
    private void ReduceSpeed(float value)
    {
        speedMultiplier /= value;
    }

    public static float GetSpeed()
    {
        return speedMultiplier;
    }
}
