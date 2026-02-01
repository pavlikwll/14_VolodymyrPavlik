using UnityEngine;

public class GemControl : MonoBehaviour
{
    public LillteDiamondsControl playerDiamonds;

    public GameObject healArea;
    public GameObject lightObj;
    public Animator animator;
    
    public void Activate()
    {
        // якщо UseThem() = true вистачає кристалів
        if (!playerDiamonds.UseThem())
        {
            Debug.Log("Not enough crystals");
            return;
        }
        
        healArea.SetActive(true);
        lightObj.SetActive(true);
        animator.SetTrigger("Activate");

        Debug.Log("The Gem activated!");
    }
}
