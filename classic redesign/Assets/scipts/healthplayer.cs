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

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        healthBar.SetSlider(currentHealth);
    }
    private void Update()
    {
        //if the player presses the "k" key
        if (Input.GetKeyDown(KeyCode.K))
        {
            TakeDamage(20f);
        }
    }
}
