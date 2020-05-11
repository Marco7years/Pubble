using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDownController : MonoBehaviour
{
    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
    }
}
