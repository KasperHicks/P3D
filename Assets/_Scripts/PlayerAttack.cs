using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{

    public GameObject arch;
    public float attackTimer;
    public float animationTimer;
    public float attackRange;
    public Transform attackPoint;
    public LayerMask enemyLayer;

    public bool canAttack = true;
    // Start is called before the first frame update
    void Start()
    {
        arch.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canAttack)
        {
            Attack();
        }
    }

    void Attack()
    {
        //attack animation
        StartCoroutine(AttackAnim());

        //detect enemies
        //Collider2D[]hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);

        //damage enemies
        //foreach(Collider2D enemy in hitEnemies)
       // {
        //    Debug.Log("We Hit " + enemy.name);
        //}
    }

    IEnumerator AttackAnim()
    {
        canAttack = false;
        arch.SetActive(true);
        //wait
        yield return new WaitForSeconds(animationTimer);
        arch.SetActive(false);
        yield return new WaitForSeconds(attackTimer);

        //load
        canAttack = true;
    }

    //private void OnDrawGizmosSelected()
    //{
    //    if (attackPoint == null)
    //        return;
    //    Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    //}
}
