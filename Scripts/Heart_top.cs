using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart_top : MonoBehaviour
{
    int count = 1;
    void Start()
    {
            GameObject obj = (GameObject)Resources.Load("Heart");
            GameObject Heart_ur = (GameObject)Instantiate(obj, new Vector3(7.0f, 15.0f, -8.0f), Quaternion.Euler(-90, 0, 0));       //�E��
            Heart_ur.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            Heart_ur.GetComponent<Renderer>().material.color = Color.red;
            GameObject Heart_under = (GameObject)Instantiate(obj, new Vector3(0.0f, 5.0f, -8.0f), Quaternion.Euler(-90, 0, 0));     //��
            Heart_under.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            Heart_under.GetComponent<Renderer>().material.color = Color.red;
            GameObject Heart_uc = (GameObject)Instantiate(obj, new Vector3(-7.0f, 15.0f, -8.0f), Quaternion.Euler(-90, 0, 0));      //����
            Heart_uc.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            Heart_uc.GetComponent<Renderer>().material.color = Color.red;
            GameObject Heart_rc = (GameObject)Instantiate(obj, new Vector3(9.0f, 10.0f, -8.0f), Quaternion.Euler(-90, 0, 0));       //�E����
            Heart_rc.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            Heart_rc.GetComponent<Renderer>().material.color = Color.red;
            GameObject Heart_cl = (GameObject)Instantiate(obj, new Vector3(-9.0f, 10.0f, -8.0f), Quaternion.Euler(-90, 0, 0));      //������
            Heart_cl.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            Heart_cl.GetComponent<Renderer>().material.color = Color.red;
            GameObject Heart_br = (GameObject)Instantiate(obj, new Vector3(7.0f, 5.0f, -8.0f), Quaternion.Euler(-90, 0, 0));        //�E��
            Heart_br.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            Heart_br.GetComponent<Renderer>().material.color = Color.red;
            GameObject Heart_bc = (GameObject)Instantiate(obj, new Vector3(-7.0f, 5.0f, -8.0f), Quaternion.Euler(-90, 0, 0));       //����
            Heart_bc.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            Heart_bc.GetComponent<Renderer>().material.color = Color.red;
            GameObject Heart_top = (GameObject)Instantiate(obj, new Vector3(0.0f, 15.0f, -8.0f), Quaternion.Euler(-90, 0, 0));      //��
            Heart_top.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            Heart_top.GetComponent<Renderer>().material.color = Color.red;
            GameObject Heart_middle = (GameObject)Instantiate(obj, new Vector3(0.0f, 10.0f, -8.0f), Quaternion.Euler(-90, 0, 0));      //����
            Heart_middle.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            Heart_middle.GetComponent<Renderer>().material.color = Color.red;
            StartCoroutine(ScaleUp(Heart_top, Heart_middle, Heart_ur, Heart_under, Heart_uc, Heart_rc, Heart_cl, Heart_br, Heart_bc));
        
    }
    IEnumerator ScaleUp(GameObject name1,GameObject name2, GameObject name3, GameObject name4, GameObject name5, GameObject name6, GameObject name7, GameObject name8, GameObject name9)
    {
        while (true)
        {
            
            Manager Manager = GetComponent<Manager>();               //FileInfo����f�[�^�������Ă���

            if (Manager.sum > 41 & count == 1)
            {        //1��     
                StartCoroutine(update(name3));   //�g�僁�\�b�h
                count = 2;


            }
            if (Manager.sum > 83 & count == 2)         //2��
            {
                StartCoroutine(update(name3));
                count = 3;


            }
            if (Manager.sum > 125 & count == 3)
            {
                StartCoroutine(update(name3));       //3��
                count = 4;
            }
            if (Manager.sum > 166 & count == 4)
            {        //1��     
                StartCoroutine(update(name6));   //�g�僁�\�b�h
                count = 5;


            }
            if (Manager.sum > 208 & count == 5)         //2��
            {
                StartCoroutine(update(name6));
                count = 6;


            }
            if (Manager.sum > 250 & count == 6)
            {
                StartCoroutine(update(name6));       //3��
                count = 7;
            }
            if (Manager.sum > 291 & count == 7)
            {        //1��     
                StartCoroutine(update(name8));   //�g�僁�\�b�h
                count = 8;


            }
            if (Manager.sum > 333 & count == 8)         //2��
            {
                StartCoroutine(update(name8));
                count = 9;


            }
            if (Manager.sum > 375 & count == 9)
            {
                StartCoroutine(update(name8));       //3��
                count = 10;
            }
            if (Manager.sum > 416& count == 10)
            {        //1��     
                StartCoroutine(update(name4));   //�g�僁�\�b�h
                count = 11;


            }
            if (Manager.sum > 458 & count == 11)         //2��
            {
                StartCoroutine(update(name4));
                count = 12;


            }
            if (Manager.sum > 500 & count ==12 )
            {
                StartCoroutine(update(name4));       //3��
                count = 13;
            }
            if (Manager.sum > 541 & count == 13)
            {        //1��     
                StartCoroutine(update(name9));   //�g�僁�\�b�h
                count = 14;


            }
            if (Manager.sum > 583 & count ==14)         //2��
            {
                StartCoroutine(update(name9));
                count = 15;


            }
            if (Manager.sum > 625 & count == 15)
            {
                StartCoroutine(update(name9));       //3��
                count = 16;
            }
            if (Manager.sum > 666 & count == 16)
            {        //1��     
                StartCoroutine(update(name7));   //�g�僁�\�b�h
                count = 17;


            }
            if (Manager.sum > 708 & count ==17)         //2��
            {
                StartCoroutine(update(name7));
                count = 18;


            }
            if (Manager.sum > 750 & count ==18)
            {
                StartCoroutine(update(name7));       //3��
                count = 19;
            }
            if (Manager.sum > 791 & count == 19)
            {        //1��     
                StartCoroutine(update(name5));   //�g�僁�\�b�h
                count = 20;


            }
            if (Manager.sum > 833 & count == 20)         //2��
            {
                StartCoroutine(update(name5));
                count = 21;


            }
            if (Manager.sum > 875 & count == 21)
            {
                StartCoroutine(update(name5));       //3��
                count = 22;
            }
            if (Manager.sum > 916 & count == 22)
            {        //1��     
                StartCoroutine(update(name1));   //�g�僁�\�b�h
                count = 23;


            }
            if (Manager.sum > 958 & count == 23)         //2��
            {
                StartCoroutine(update(name1));
                count = 24;


            }
            if (Manager.sum > 999 & count == 24)
            {
                StartCoroutine(update(name1));       //3��
                count = 25;
            }
            if (Manager.sum > 1100 & count == 25)
            {

                StartCoroutine(move_uc(name5));
                StartCoroutine(move_under(name4));
                StartCoroutine(move_ur(name3));
                StartCoroutine(move_rc(name6));
                StartCoroutine(move_cl(name7));
                StartCoroutine(move_br(name8));
                StartCoroutine(move_bc(name9));
                StartCoroutine(move_top(name1));
                count = 26;
            }
            if(Manager.sum > 1400 & count == 26)
            {
                StartCoroutine(update_middle(name2,name1, name3, name4, name5, name6, name7, name8, name9));
                count = 27;
            }
            if(Manager.sum> 1800& count == 27)
            {
                Destroy(name2.gameObject);
                break;
            }
            yield return new WaitForSeconds(10.0f);                     //1�b��Ɉȉ������s ok
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

    public IEnumerator move_top(GameObject name)                    //��̃n�[�g�ړ�
    {
        yield return new WaitForSeconds(6.0f);                     //6�b��Ɉȉ������s ok
        for (int i = 0; i < 4; i++)
        {
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.0f, -0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.0f, -0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.0f, -0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.0f, -0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.0f, -0.2f, 0);
        }
    }
    public IEnumerator update_middle(GameObject name, GameObject name1, GameObject name2, GameObject name3, GameObject name4, GameObject name5, GameObject name6, GameObject name7, GameObject name8)                     //5�b�Ԋg��
    {
        yield return StartCoroutine(Destroy(name1, name2, name3, name4, name5, name6, name7, name8));
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
    public IEnumerator move_ur(GameObject name)                    //�E��̃n�[�g�ړ�
    {
        yield return new WaitForSeconds(6.0f);                     //6�b��Ɉȉ������s ok
        for (int i = 0; i < 4; i++)
        {
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(-0.2f, -0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(-0.2f, -0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(-0.2f, -0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(-0.2f, -0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(-0.2f, -0.2f, 0);
        }
    }
    public IEnumerator move_under(GameObject name)                 //���̃n�[�g�ړ�
    {
        yield return new WaitForSeconds(6.0f);                     //6�b��Ɉȉ������s ok
        for (int i = 0; i < 4; i++)
        {
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.0f, 0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.0f, 0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.0f, 0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.0f, 0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.0f, 0.2f, 0);
        }
    }
    public IEnumerator move_uc(GameObject name)                     //����̃n�[�g�ړ�
    {
        yield return new WaitForSeconds(6.0f);                     //6�b��Ɉȉ������s ok
        for (int i = 0; i < 4; i++)
        {
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.2f, -0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.2f, -0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.2f, -0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.2f, -0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.2f, -0.2f, 0);
        }
    }

    public IEnumerator move_rc(GameObject name)                    //�E�����̃n�[�g�ړ�
    {
        yield return new WaitForSeconds(6.0f);                     //6�b��Ɉȉ������s ok
        for (int i = 0; i < 4; i++)
        {
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(-0.3f, 0.0f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(-0.3f, 0.0f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(-0.3f, 0.0f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(-0.3f, 0.0f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(-0.3f, 0.0f, 0);
        }
    }

    public IEnumerator move_cl(GameObject name)                     //�������̃n�[�g�ړ�
    {
        yield return new WaitForSeconds(6.0f);                     //6�b��Ɉȉ������s ok
        for (int i = 0; i < 4; i++)
        {
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.3f, 0.0f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.3f, 0.0f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.3f, 0.0f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.3f, 0.0f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.3f, 0.0f, 0);
        }
    }
    public IEnumerator move_br(GameObject name)                     //�E���̃n�[�g�ړ�
    {
        yield return new WaitForSeconds(6.0f);                     //6�b��Ɉȉ������s ok
        for (int i = 0; i < 4; i++)
        {
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(-0.2f, 0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(-0.2f, 0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(-0.2f, 0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(-0.2f, 0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(-0.2f, 0.2f, 0);
        }
    }
    public IEnumerator move_bc(GameObject name)                     //�����̃n�[�g�ړ�
    {
        yield return new WaitForSeconds(6.0f);                     //6�b��Ɉȉ������s ok
        for (int i = 0; i < 4; i++)
        {
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.2f, 0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.2f, 0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.2f, 0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.2f, 0.2f, 0);
            yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
            name.transform.position = name.transform.position + new Vector3(0.2f, 0.2f, 0);
        }
    }
    // Destroy���I�������update_middle�����s

    public IEnumerator Destroy(GameObject name, GameObject name1, GameObject name2, GameObject name3, GameObject name4, GameObject name5, GameObject name6, GameObject name7)
    {
        
        Destroy(name.gameObject);
        Destroy(name1.gameObject);
        Destroy(name2.gameObject);
        Destroy(name3.gameObject);
        Destroy(name4.gameObject);
        Destroy(name5.gameObject);
        Destroy(name6.gameObject);
        Destroy(name7.gameObject);
        yield return new WaitForSeconds(1.0f);                     //1�b��Ɉȉ������s ok
    }
}
