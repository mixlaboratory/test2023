using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    //-----------------------------------------------------------
    //����Ăق�������:�uStartCoroutine(update(Heart_ur))�v(�g�僁�\�b�h)�����̃n�[�g�����܂ł�if����2��
    //                  ���̃n�[�g��������1����Ăق���
    //----------------------------------------------------------
    public int sum = 0;           //Manager�Ŏg���f�[�^
    int heart_flag = 0;     //����ɑ��₷���ǂ���
    int num = 0;

    void Start()
    {
        StartCoroutine(deta());
    }
    public IEnumerator deta()
    {



        while (true)
        {
            GameObject obj = (GameObject)Resources.Load("Heart");
            FileInfo FileInfo = GetComponent<FileInfo>();               //FileInfo����f�[�^�������Ă���
            sum = FileInfo.data + sum;                                       //sum��FileInfo��sum������



            if (sum > 1800)
            {

                sum = 0;
                heart_flag = 1;
                if (heart_flag == 1)
                {
                    GameObject mini_Heart = (GameObject)Instantiate(obj, new Vector3(-12.0f, 16.5f, -8.0f), Quaternion.Euler(-90, 0, 0));
                    mini_Heart.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                    mini_Heart.GetComponent<Renderer>().material.color = Color.red;
                    num++;
                    text text = GetComponent<text>();
                    text.num++;
                    heart_flag = 0;
                }
            }
            yield return new WaitForSeconds(10.0f);                     //1�b��Ɉȉ������s ok
            Debug.Log(sum);
        }
    }
                                                                                                          
          
            



    public IEnumerator update(GameObject name)                     //5�b�Ԋg��
    {
        yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
        name.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
        name.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
        name.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
        name.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
        name.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);

        Debug.Log("�傫���Ȃ���");                          //�m�Fok


    }

   
    

    

    
    
    
    
    

    
    
}

