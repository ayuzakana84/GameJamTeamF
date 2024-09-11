using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    CurrentFoot currentFoot;
    ToGameOver toGameOver;

    void Start()
    {
        currentFoot = GameObject.FindWithTag("FootManager").GetComponent<CurrentFoot>();
        toGameOver=GameObject.FindWithTag("PlayerManager").GetComponent<ToGameOver>();  
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //�������Ă�����̌C����Q���ɐG�ꂽ��Q�[���I�[�o�[
        if (currentFoot.CurrentMovingFoot()&& collision.CompareTag("LeftFoot"))//����
        {
            toGameOver.GameoverTrigger();
        }
        else if(!currentFoot.CurrentMovingFoot() && collision.CompareTag("RightFoot"))//�E��
        {
            toGameOver.GameoverTrigger();
        }
        
    }
}
