using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ShopBuildingButton : MonoBehaviour
{
    [SerializeField] private List<Building> building;
    private List<Building> _nonActiveBuilding;

    private void Start()
    {
        _nonActiveBuilding = new List<Building>();
        foreach (var build in building)
        {
            if (!build.isActiveAndEnabled)
            {
                _nonActiveBuilding.Add(build);
            }
        }
    }

    public void AddItemIfCan(string itemTag)
    {
        foreach (var builds in _nonActiveBuilding)
        {
            if (builds.CompareTag(itemTag))
            {
                builds.gameObject.SetActive(true);
                _nonActiveBuilding.Remove(builds);
                return;
            }
        }
    }
}
