using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    // UI Text�w��p
    public Text TextFrame;
    // �\������ϐ�
    public int num;
    //Manager Manager = GetComponent<Manager>();               //FileInfo����f�[�^�������Ă���
    //num += Manager.num;                                       //sum��FileInfo��sum������

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        TextFrame.text = string.Format("�~{0}", num);
    }
}