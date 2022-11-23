using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Vector3 objPosition;
    [SerializeField] public int currentHealth;

    [SerializeField] public int maxHealth;

    public HealthBar healthBar;

    public ClueInventory clues;

    public ClueInventory clueLibrary;

    public GameObject rope;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            objPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(rope, new Vector3(objPosition.x, objPosition.y, rope.transform.position.z), Quaternion.identity, GameObject.Find("Board").transform);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
