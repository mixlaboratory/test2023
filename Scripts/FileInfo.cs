using System.IO;
using System.Text;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FileInfo : MonoBehaviour
{
    public int data;
    public int flag = 1;
    private int count;              // �J�E���^�[
    void Start()
    {
        // �J�E���^�[��������
        count = 0;


        // �R���[�`���̐ݒ�
        StartCoroutine(move());
    }

    private IEnumerator move()
    {
        while (true)
        {
            // �R���[�`���̓Q�[���I�u�W�F�N�g����A�N�e�B�u
            // �ɂȂ�Ə���Ɏ~�܂�̂ŁA�������[�v�ł�OK
            string text = ContentOfTxtFile(@"C:\Users\hidek\data.txt");
            Debug.Log(text);
            data = int.Parse(text);   // int�ɕϊ�
            // �J�E���g�A�b�v
            count++;

            // ���O�o��
            Debug.Log(count + "��ڂ̎��s�ł��B");

            // 10�b�Ԃ�1�x���s����ݒ�
            yield return new WaitForSeconds(10);
        }
    }

    public static string ContentOfTxtFile(string iPath)
    {
        //Text�t�@�C�������݂���Ȃ�ǂݎ���āA�����Ȃ�null��ԋp
        if (File.Exists(iPath)) return ReadText(iPath);

        Debug.LogError("Txt file not found");
        return null;
    }

    #region ReadText
    private static string ReadText(string iPath)
    {
        // �e�L�X�g�ǂݍ��ݏ���
        using var fs = new FileStream(iPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        using var reader = new StreamReader(fs, Encoding.UTF8);
        string textContent = reader.ReadToEnd();
        return textContent;
    }
    #endregion


}