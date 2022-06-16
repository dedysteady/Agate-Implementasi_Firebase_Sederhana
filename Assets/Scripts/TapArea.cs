using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TapArea : MonoBehaviour, IPointerDownHandler
{
    public AudioSource gameClip;

    public void OnPointerDown (PointerEventData eventData)
    {
        GameManager.Instance.CollectByTap (eventData.position, transform);
        gameClip.Play();
    }
}