using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CliquearLugar : MonoBehaviour
{
    public bool seHizoClick = false;

    void OnMouseDown()
    {
        seHizoClick = true;
        Debug.Log(seHizoClick);
    }
}
