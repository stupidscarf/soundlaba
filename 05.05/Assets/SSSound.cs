using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSSound : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Play();
        }
    }
    private void Play() => _source.Play();
}
