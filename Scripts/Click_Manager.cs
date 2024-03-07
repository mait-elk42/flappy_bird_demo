using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Click_Manager : EventTrigger
{
    public override void OnPointerClick(PointerEventData eventData)
    {
        print(eventData);
    }
}
