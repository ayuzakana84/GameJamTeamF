using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;//動く速さ
    //[SerializeField] GameObject left;//左足
    //[SerializeField] GameObject right;//右足
    //bool moveLeftNow = true;//今左足を動かしているか、最初に動かすのは左足

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void SwitchMoveFoot()//動かす足を入れ替える
    //{
    //    moveLeftNow=!moveLeftNow;//動かす足を反転
    //}

    public void MoveControl()
    {
        Vector2 move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        //if (moveLeftNow)//左足を動かしている
        //{
        //    left.transform.Translate(move * speed * Time.deltaTime);
        //}
        //else//右足を動かしている
        //{
        //    right.transform.Translate(move * speed * Time.deltaTime);
        //}

        transform.Translate(move * speed * Time.deltaTime);


    }
}
