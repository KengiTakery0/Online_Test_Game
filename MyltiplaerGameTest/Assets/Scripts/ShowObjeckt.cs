using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObjeckt : MonoBehaviour
{
    [SerializeField] GameObject gameObject;
    private void Update()
    {
        if (gameObject.active == false)
            gameObject.SetActive(true);
    }
}
