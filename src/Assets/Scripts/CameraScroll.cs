using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    [SerializeField] float scrollSpeed;//�X�N���[���̑���
    bool scrollNow=false;//���݃X�N���[�����Ă��邩�A�����J�����ɐG��Ă��鎞�̓X�N���[������
    ToGameOver toGameOver;
    public bool ScrollNow
    {
        get { return scrollNow; }
    }

    // Start is called before the first frame update
    void Start()
    {
        toGameOver = GameObject.FindWithTag("PlayerManager").GetComponent<ToGameOver>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScrollTrigger()//�X�N���[�����ɌĂ�(�������ԊJ�n���ɌĂ΂Ȃ��ƃX�N���[������Ȃ�)
    {
        scrollNow = true;
    }

    public void Scroll()//�X�N���[�����Ă�Ԃ�true�A���ĂȂ��Ԃ�false��Ԃ�
    {
        if (scrollNow&&!toGameOver)
        {
            Vector2 move= Vector2.up;
            transform.Translate(move*scrollSpeed*Time.deltaTime);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("ScrollFoot"))
        {
            scrollNow = false;
            Debug.Log("�G��Ă܂���");
        }
    }
}
