using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class INTRO : MonoBehaviour
{
    public int STR;
    public int HP;
    public int DMG;
    // Start is called before the first frame update
    void Start()
    {

        HP = 5 * STR;
    }

    // Update is called once per frame
    void Update()
    {
        HP = 5 * STR;
     
        if (Input.GetKeyDown(KeyCode.Space)) {
        // when we press spacebar
        //call function
        TakeDamage();
        }
        if (HP < 0)
        {
            Debug.Log("You Dead");
            HP = 0;

        }
    }
    void TakeDamage()
    {
        // HP = HP - DMG
        HP -= DMG;
    }
}
