using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    public Slider sliderM;
    public Image Mana;
    public void SetMaxMana(int Mana)
    {
        sliderM.maxValue = Mana;
        sliderM.value = Mana;
    }
    public void SetMana(int Mana)
    {
        sliderM.value = Mana;
    }
}
