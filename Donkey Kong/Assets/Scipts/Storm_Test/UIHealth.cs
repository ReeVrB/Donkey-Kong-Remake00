using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHealth : MonoBehaviour
{
    [SerializeField] GameObject EmptyHP;
    [SerializeField] GameObject HP1;
    [SerializeField] GameObject HP2;
    [SerializeField] GameObject HP3;
    [SerializeField] string Timer;
    private PlayerController m_playerHealth;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        m_playerHealth = FindObjectOfType<PlayerController>();
        timer = 0;
        //Timer =
    }

    // Update is called once per frame
    void Update()
    {
       timer += Time.deltaTime;

        if (m_playerHealth.currentHealth <= 2)
        {
            HP3.SetActive(false);
        }

        if (m_playerHealth.currentHealth <= 1)
        {
            HP2.SetActive(false);
        }

        if (m_playerHealth.currentHealth < 1)
        {
            HP1.SetActive(false);
            EmptyHP.SetActive(false);
        }
    }
}
