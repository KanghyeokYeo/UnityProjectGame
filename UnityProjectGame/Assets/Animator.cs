using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animator : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] KeyCode key1 = KeyCode.UpArrow;
    [SerializeField] bool HeadGuard;

    public void Update()
    {
        if (Input.GetKeyDown(key1))
        {

        }
    }
}
