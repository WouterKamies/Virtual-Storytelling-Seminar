using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class Room : MonoBehaviour
{
    public Transform snapPoint;

    [Button]
    public void SnapTo()
    {
        transform.position = snapPoint.position;
        transform.right = snapPoint.right;
    }
}
