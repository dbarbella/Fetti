using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poof : MonoBehaviour
{

    [field: SerializeField] public GameObject EffectOnDestroyPrefab { get; private set; }
    void OnDestroy()
    {
        if (EffectOnDestroyPrefab)
        {
            Instantiate(EffectOnDestroyPrefab, transform.position, Quaternion.identity);
        }
    }
}
