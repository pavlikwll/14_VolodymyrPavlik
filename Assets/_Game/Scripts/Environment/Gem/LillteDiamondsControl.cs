using UnityEngine;

public class LillteDiamondsControl : MonoBehaviour
{
    // Простий лічильник. НЕ інвентар.
    public int lildiams = 0;

    // UnityEvent буде викликати це напряму
    public void AddLilDiam()
    {
        lildiams++;
        Debug.Log("Crystals: " + lildiams);
    }

    // перевірка чи є 3
    public bool UseThem()
    {
        if (lildiams < 3)
        {
            return false;
        }
        
        lildiams = 3;
        return true;
    }
}
