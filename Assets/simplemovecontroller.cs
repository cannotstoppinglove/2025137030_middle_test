using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplemovecontroller : MonoBehaviour
{
    public Animator myAnimator;
    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator.SetBool("move", false);
    }
    // Update is called once per fram
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        
        if(direction > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1);
            myAnimator.SetBool("move", true);

        }
        else if(direction < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1);
            myAnimator.SetBool("move", true);

        }
        else
        {
            myAnimator.SetBool("move", false);
        }

            transform.Translate(Vector3.right * direction * speed * Time.deltaTime);
    }
}
