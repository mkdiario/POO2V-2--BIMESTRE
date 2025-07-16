using System
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UI;

public class Rotaciona : MonoBehaviour
{
    public GameObject objeto;
    public Slider Slider;
    void Update()
    {
        objeto.transform.rotation = Quaternion.Euler(0, 0, Slider.value);
      
        objeto.GetComponent<SpriteRenderer>().color = new Color (Slider.value*(13.14f/180),  0, 0);
    }
}