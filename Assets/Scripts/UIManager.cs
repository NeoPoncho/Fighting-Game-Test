using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Slider healthBar;
    [SerializeField] private Image healthFill;
    [SerializeField] private Gradient gradient;

    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetInitialHealth(int maxHealth)
    {
        healthBar.maxValue = maxHealth;
        healthBar.value = maxHealth;

        healthFill.color = gradient.Evaluate(1f);
    }

    public void UpdateHealth(int currentHealth)
    {
        healthBar.value = currentHealth;

        healthFill.color = gradient.Evaluate(healthBar.normalizedValue);

        if (currentHealth < 1)
        {
            gameOver.SetActive(true);

            StartCoroutine(Reset());
        }
    }

    IEnumerator Reset()
    {
        yield return new WaitForSeconds(9);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
