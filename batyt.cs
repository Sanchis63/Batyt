using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class batyt : RUN
// RUN - ���������� ������, � ��� �� � �������������� ������������ � ����������
{
public RUN rUN;
    new public void Update()
    {
        
        if (rUN.ToJump == true)
        {
            rUN.JunpForce = 350;
        }
        else
        {
            rUN.JunpForce = 200;
        }
    }
}
