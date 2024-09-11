using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoNextStage : MonoBehaviour
{
    enum Scene
    {
        level2,
        level3, 
        clear
    }

    [SerializeField] Scene scene;
    [SerializeField] bool fadeOut;
    [SerializeField] float fadeDuration;//���b���S�ɈÓ]
    [SerializeField] float displayImageDuration;//���S�ɈÓ]���Ă��牽�b�ŃV�[����J�ڂ��邩
    [SerializeField] CanvasGroup canvasGroup;
    float m_Timer;
    bool change=false;//�V�[����ύX���邩(true�Ȃ��ʂ̈Ó]���n�܂��ăV�[���J�ڂ���)

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("LeftFoot")|| collision.CompareTag("RightFoot"))//�����������玟�̃V�[����
        {
            change = true;
        }
    }

    void Update()
    {
        if(change)
        {
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        if(fadeOut)//�t�F�[�h�A�E�g����Ȃ�
        {
            if (FadeOut()) return; //�t�F�[�h�A�E�g
        }

        switch(scene)
        {
            case Scene.level2: SceneManager.LoadScene("Lv2Scene"); break;
            case Scene.level3: SceneManager.LoadScene("Lv3Scene"); break;
            case Scene.clear: SceneManager.LoadScene("ClearScene"); break;
        }
    }

    bool FadeOut()//�܂��t�F�[�h�A�E�g�������Ă��Ȃ��Ȃ�true�A���������Ȃ�false��Ԃ�
    {
        m_Timer += Time.deltaTime;

        canvasGroup.alpha = m_Timer / fadeDuration;

        return (m_Timer <= fadeDuration + displayImageDuration);
    }
}
