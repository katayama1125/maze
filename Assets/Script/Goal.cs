using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    public GameObject GoalText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Flower")
        {
            this.GoalText.SetActive(true);
        }
    }
}