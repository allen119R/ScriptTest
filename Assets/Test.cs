using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // �̗�
    private int power = 25; // �U����
    private int mp = 53; //���@�U���p

    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
        this.hp -= damage;
    }

    //���@�U���p�̊֐�
    public void Magic() 
    {
        if (mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + mp + "�B");
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }      
    }
}    

public class Test : MonoBehaviour
{
    void Start()
    {
        //�ۑ�1
        int[] array = { 1, 2, 3, 4, 5 };
        //�ۑ�2
        for (int i = 0; i < array.Length; i++) 
        {
            Debug.Log(array[i]);
        }
        //�ۑ�3
        for (int i = array.Length-1;  i >=0; i--) 
        {
            Debug.Log(array[i]);
        }

        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        // �U���p�̊֐����Ăяo��
        lastboss.Attack();

        // �h��p�̊֐����Ăяo��
        lastboss.Defence(3);
       
        //���@�U���p�̊֐���10��Ăяo��
        for (int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }

        // ���@�U���p�̊֐����Ăяo��
        lastboss.Magic();
    }

    // Update is called once per frame
    void Update()
    {

    }
}