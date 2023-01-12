using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour
{
    public GameObject mainCamera;      //���C���J�����i�[�p
    public GameObject subCamera;       //�T�u�J�����i�[�p 


    void Start() {
        //���C���J�����ƃT�u�J���������ꂼ��擾
        mainCamera = GameObject.Find("MainCamera");
        subCamera = GameObject.Find("SubCamera");

        //�T�u�J�������A�N�e�B�u�ɂ���
        subCamera.SetActive(false);
    }

    void Update() {
        //�X�y�[�X�L�[��������Ă���ԁA�T�u�J�������A�N�e�B�u�ɂ���
        if (Input.GetKey("space"))
        {
            //�T�u�J�������A�N�e�B�u�ɐݒ�
            mainCamera.SetActive(false);
            subCamera.SetActive(true);
        }
        if (Input.GetKey("d"))
        {
            //���C���J�������A�N�e�B�u�ɐݒ�
            subCamera.SetActive(false);
            mainCamera.SetActive(true);
        }
        if (Input.GetKey("q"))
        {
            UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
        }
    }

    //�֐��F�I�u�W�F�N�g���N���b�N�����ꍇ�̓���
    public void OnClickObject(string button)
    {
        switch (button)
        {
            case "sound":
                mainCamera.SetActive(false);
                subCamera.SetActive(true);
                //�I�u�W�F�N�g������
                Debug.Log("�N���b�N");
                break;

            case "exit":
                UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
                Debug.Log("�I���N���b�N");
                break;

            case "stamp":
                Debug.Log("�X�^���v�N���b�N");
                break;

            case "back":
                Debug.Log("�o�b�N");
                mainCamera.SetActive(true);
                subCamera.SetActive(false);
                break;
        }
        
    }
}
