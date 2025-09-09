using UnityEngine;

public class healthplayer : MonoBehaviour
{
    [SerializeField] private float maxHealth;

    private float currentHealth;

    public healthbar healthBar;
    private void Start()
    {
        currentHealth = maxHealth;

        healthBar.SetSliderMax(maxHealth);
    }
}
