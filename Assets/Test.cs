using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^�����B");
    }

    public void Defence(int damege)
    {
        Debug.Log(damege + "�̃_���[�W���󂯂��B");
        this.hp -= damege;
    }

    public void Magic()
    {
        if(mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + this.mp);
        }

        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        for( int i = 0; i <= 4; i++)
        {
            Debug.Log(array[i]);
        }

        for( int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        Boss lastboss = new Boss();

        lastboss.Attack();
        lastboss.Defence(3);

        for( int i = 0; i < 10; i ++)
        {
            lastboss.Magic();
        }

        lastboss.Magic();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
