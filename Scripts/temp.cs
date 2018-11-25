﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class temp : MonoBehaviour {

    //=========================================================================
    // find the GameObject that need to change clolor
    private GameObject obj;
    // surronding game objects
    private GameObject obj1 = null;
    private GameObject obj2 = null;
    private GameObject obj3 = null;
    private GameObject obj4 = null;
    // find the name of the GameObject described above
    private char[] objName = new char[12];
    private string ObjName;
    private static bool canChange = true;
    //=========================================================================

    //=========================================================================
    // Use this for initialization
    void Start()
    {

        // change the current game object name to char array
        // format:
        // blok(  )(  )
        // 012345678901
        ObjName = gameObject.name;
        objName = ObjName.ToCharArray();

        // settle color as black
        // settle visable as false
        obj = GameObject.Find("" + gameObject.name);
        obj.GetComponent<Renderer>().material.color = Color.red;
        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = false;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    //=========================================================================

    //=========================================================================
    public void OnMouseEnter()
    {
        //whatIsCurrentColor(main.player, obj);

        //howToDisplay(main.blok, main.side, main.angle);
    }

    public void OnMouseExit()
    {
        //howToHide(main.blok, main.side, main.angle);
    }
    //=========================================================================

    //=========================================================================
    public void whatIsCurrentColor(int index, GameObject obj)
    {
        if (index == 1)
        {
            obj.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (index == 2)
        {
            obj.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (index == 3)
        {
            obj.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (index == 4)
        {
            obj.GetComponent<Renderer>().material.color = Color.blue;
        }
        else
        {
            obj.GetComponent<Renderer>().material.color = Color.black;
        }
    }

    private void howToDisplay(int index, int side, int angle)
    {
        if (index == 0)
        {
            S_special_condition();
        }
        else if (index == 1)
        {
            S_Blok1_side1_angle1();
        }
        else if (index == 4)
        {
            if (angle == 1 || angle == 3)
            {
                S_Blok4_side1_angle1();
            }
            else if (angle == 2 || angle == 4)
            {
                S_Blok4_side1_angle2();
            }
        }
        else if (index == 9)
        {
            
        }
        else if (index == 15)
        {
            if (angle == 1 || angle == 3)
            {
                S_Blok15_side1_angle1();
            }
            else if (angle == 2 || angle == 4)
            {
                S_Blok15_side1_angle2();
            }
        }
        else if (index == 20)
        {
            S_Blok20_side1_angle1();
        }
    }

    private void howToHide(int index, int side, int angle)
    {
        if (index == 0)
        {
            H_special_condition();
        }
        else if (index == 1)
        {
            H_Blok1_side1_angle1();
        }
        else if (index == 4)
        {
            if (angle == 1 || angle == 3)
            {
                H_Blok4_side1_angle1();
            }
            else if (angle == 2 || angle == 4)
            {
                H_Blok4_side1_angle2();
            }
        }
        else if (index == 9)
        {
            
        }
        else if (index == 15)
        {
            if (angle == 1 || angle == 3)
            {
                H_Blok15_side1_angle1();
            }
            else if (angle == 2 || angle == 4)
            {
                H_Blok15_side1_angle2();
            }
        }
        else if (index == 20)
        {
            H_Blok20_side1_angle1();
        }
    }
    //=========================================================================

    //=========================================================================

    public void gameobjectToZero()
    {
        obj1 = null;
        obj2 = null;
        obj3 = null;
        obj4 = null;
    }


    //=========================================================================

    //=========================================================================
    //-------------------------------------------------------------------------
    private void S_special_condition()
    {
        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(false);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = true;
        }
    }
    private void H_special_condition()
    {
        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = false;
        }
    }
    //-------------------------------------------------------------------------
    private void S_Blok1_side1_angle1()
    {
        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(false);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = true;
        }
    }
    private void H_Blok1_side1_angle1()
    {
        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = false;
        }
    }
    //-------------------------------------------------------------------------
    private void S_Blok4_side1_angle1()
    {
        char[] temp = new char[objName.Length];
        temp = objName;

        obj1 = GameObject.Find(methodsLib.blokCoordinate(temp, -1, 0));
        obj2 = GameObject.Find(methodsLib.blokCoordinate(temp, 1, 0));

        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(false);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = true;
        }

        if (obj1 != null && canChange == true)
        {
            MeshRenderer[] marr1 = obj1.GetComponentsInChildren<MeshRenderer>(false);
            foreach (MeshRenderer m in marr1)
            {
                m.enabled = true;
            }
        }
        else { }

        if (obj2 != null && canChange == true)
        {
            MeshRenderer[] marr2 = obj2.GetComponentsInChildren<MeshRenderer>(false);
            foreach (MeshRenderer m in marr2)
            {
                m.enabled = true;
            }
        }
        else { }

        gameobjectToZero();
    }
    private void S_Blok4_side1_angle2()
    {
        char[] temp = new char[objName.Length];
        temp = objName;

        obj1 = GameObject.Find(methodsLib.blokCoordinate(temp, 0, -1));
        obj2 = GameObject.Find(methodsLib.blokCoordinate(temp, 0, 1));

        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(false);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = true;
        }

        if (obj1 != null)
        {
            MeshRenderer[] marr1 = obj1.GetComponentsInChildren<MeshRenderer>(false);
            foreach (MeshRenderer m in marr1)
            {
                m.enabled = true;
            }
        }
        else { }

        if (obj2 != null && canChange == true)
        {
            MeshRenderer[] marr2 = obj2.GetComponentsInChildren<MeshRenderer>(false);
            foreach (MeshRenderer m in marr2)
            {
                m.enabled = true;
            }
        }
        else { }

        gameobjectToZero();
    }
    private void H_Blok4_side1_angle1()
    {
        char[] temp = new char[objName.Length];
        temp = objName;

        obj1 = GameObject.Find(methodsLib.blokCoordinate(temp, -1, 0));
        obj2 = GameObject.Find(methodsLib.blokCoordinate(temp, 1, 0));

        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = false;
        }

        if (obj1 != null && canChange == true)
        {
            MeshRenderer[] marr1 = obj1.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr1)
            {
                m.enabled = false;
            }
        }
        else { }

        if (obj2 != null && canChange == true)
        {
            MeshRenderer[] marr2 = obj2.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr2)
            {
                m.enabled = false;
            }
        }
        else { }

        gameobjectToZero();
    }

    private void H_Blok4_side1_angle2()
    {
        char[] temp = new char[objName.Length];
        temp = objName;

        obj1 = GameObject.Find(methodsLib.blokCoordinate(temp, 0, -1));
        obj2 = GameObject.Find(methodsLib.blokCoordinate(temp, 0, 1));

        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = false;
        }

        if (obj1 != null && canChange == true)
        {
            MeshRenderer[] marr1 = obj1.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr1)
            {
                m.enabled = false;
            }
        }
        else { }

        if (obj2 != null && canChange == true)
        {
            MeshRenderer[] marr2 = obj2.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr2)
            {
                m.enabled = false;
            }
        }
        else { }

        gameobjectToZero();
    }
    //-------------------------------------------------------------------------
    private void S_Blok9_side1_angle1()
    {
        char[] temp = new char[objName.Length];
        temp = objName;

        obj1 = GameObject.Find(methodsLib.blokCoordinate(temp, 0, -1));
        obj2 = GameObject.Find(methodsLib.blokCoordinate(temp, -1, 0));
        obj3 = GameObject.Find(methodsLib.blokCoordinate(temp, -2, 0));

        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(false);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = true;
        }

        if (obj1 != null && canChange == true)
        {
            MeshRenderer[] marr1 = obj1.GetComponentsInChildren<MeshRenderer>(false);
            foreach (MeshRenderer m in marr1)
            {
                m.enabled = true;
            }
        }
        else { }

        if (obj2 != null && canChange == true)
        {
            MeshRenderer[] marr2 = obj2.GetComponentsInChildren<MeshRenderer>(false);
            foreach (MeshRenderer m in marr2)
            {
                m.enabled = true;
            }
        }
        else { }

        if (obj3 != null && canChange == true)
        {
            MeshRenderer[] marr3 = obj3.GetComponentsInChildren<MeshRenderer>(false);
            foreach (MeshRenderer m in marr3)
            {
                m.enabled = true;
            }
        }
        else { }

        gameobjectToZero();
    }
    private void S_Blok9_side1_angle2()
    {

    }
    private void S_Blok9_side1_angle3()
    {

    }
    private void S_Blok9_side1_angle4()
    {

    }
    private void S_Blok9_side2_angle1()
    {

    }
    private void S_Blok9_side2_angle2()
    {

    }
    private void S_Blok9_side2_angle3()
    {

    }
    private void S_Blok9_side2_angle4()
    {

    }

    private void H_Blok9_side1_angle1()
    {
        char[] temp = new char[objName.Length];
        temp = objName;

        obj1 = GameObject.Find(methodsLib.blokCoordinate(temp, 0, -1));
        obj2 = GameObject.Find(methodsLib.blokCoordinate(temp, -1, 0));
        obj3 = GameObject.Find(methodsLib.blokCoordinate(temp, -2, 0));

        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = false;
        }

        if (obj1 != null && canChange == true)
        {
            MeshRenderer[] marr1 = obj1.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr1)
            {
                m.enabled = false;
            }
        }
        else { }

        if (obj2 != null && canChange == true)
        {
            MeshRenderer[] marr2 = obj2.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr2)
            {
                m.enabled = false;
            }
        }
        else { }

        if (obj3 != null && canChange == true)
        {
            MeshRenderer[] marr3 = obj3.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr3)
            {
                m.enabled = false;
            }
        }
        else { }

        gameobjectToZero();
    }
    private void H_Blok9_side1_angle2()
    {

    }
    private void H_Blok9_side1_angle3()
    {

    }
    private void H_Blok9_side1_angle4()
    {

    }
    private void H_Blok9_side2_angle1()
    {

    }
    private void H_Blok9_side2_angle2()
    {

    }
    private void H_Blok9_side2_angle3()
    {

    }
    private void H_Blok9_side2_angle4()
    {

    }
    //-------------------------------------------------------------------------
    private void S_Blok15_side1_angle1()
    {
        char[] temp = new char[objName.Length];
        temp = objName;

        obj1 = GameObject.Find(methodsLib.blokCoordinate(temp, -1, 0));
        obj2 = GameObject.Find(methodsLib.blokCoordinate(temp, 1, 0));
        obj3 = GameObject.Find(methodsLib.blokCoordinate(temp, -2, 0));
        obj4 = GameObject.Find(methodsLib.blokCoordinate(temp, 2, 0));

        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(false);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = true;
        }

        if (obj1 != null && canChange == true)
        {
            MeshRenderer[] marr1 = obj1.GetComponentsInChildren<MeshRenderer>(false);
            foreach (MeshRenderer m in marr1)
            {
                m.enabled = true;
            }
        }
        else { }

        if (obj2 != null && canChange == true)
        {
            MeshRenderer[] marr2 = obj2.GetComponentsInChildren<MeshRenderer>(false);
            foreach (MeshRenderer m in marr2)
            {
                m.enabled = true;
            }
        }
        else { }

        if (obj3 != null && canChange == true)
        {
            MeshRenderer[] marr3 = obj3.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr3)
            {
                m.enabled = true;
            }
        }
        else { }

        if (obj4 != null && canChange == true)
        {
            MeshRenderer[] marr4 = obj4.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr4)
            {
                m.enabled = true;
            }
        }
        else { }

        gameobjectToZero();
    }
    private void S_Blok15_side1_angle2()
    {
        char[] temp = new char[objName.Length];
        temp = objName;

        obj1 = GameObject.Find(methodsLib.blokCoordinate(temp, 0, -1));
        obj2 = GameObject.Find(methodsLib.blokCoordinate(temp, 0, 1));
        obj3 = GameObject.Find(methodsLib.blokCoordinate(temp, 0, -2));
        obj4 = GameObject.Find(methodsLib.blokCoordinate(temp, 0, 2));

        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(false);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = true;
        }

        if (obj1 != null && canChange == true)
        {
            MeshRenderer[] marr1 = obj1.GetComponentsInChildren<MeshRenderer>(false);
            foreach (MeshRenderer m in marr1)
            {
                m.enabled = true;
            }
        }
        else { }

        if (obj2 != null && canChange == true)
        {
            MeshRenderer[] marr2 = obj2.GetComponentsInChildren<MeshRenderer>(false);
            foreach (MeshRenderer m in marr2)
            {
                m.enabled = true;
            }
        }
        else { }

        if (obj3 != null && canChange == true)
        {
            MeshRenderer[] marr3 = obj3.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr3)
            {
                m.enabled = true;
            }
        }
        else { }

        if (obj4 != null && canChange == true)
        {
            MeshRenderer[] marr4 = obj4.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr4)
            {
                m.enabled = true;
            }
        }
        else { }

        gameobjectToZero();
    }
    private void H_Blok15_side1_angle1()
    {
        char[] temp = new char[objName.Length];
        temp = objName;

        obj1 = GameObject.Find(methodsLib.blokCoordinate(temp, -1, 0));
        obj2 = GameObject.Find(methodsLib.blokCoordinate(temp, 1, 0));
        obj3 = GameObject.Find(methodsLib.blokCoordinate(temp, -2, 0));
        obj4 = GameObject.Find(methodsLib.blokCoordinate(temp, 2, 0));

        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = false;
        }

        if (obj1 != null && canChange == true)
        {
            MeshRenderer[] marr1 = obj1.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr1)
            {
                m.enabled = false;
            }
        }
        else { }

        if (obj2 != null && canChange == true)
        {
            MeshRenderer[] marr2 = obj2.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr2)
            {
                m.enabled = false;
            }
        }
        else { }

        if (obj3 != null && canChange == true)
        {
            MeshRenderer[] marr3 = obj3.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr3)
            {
                m.enabled = false;
            }
        }
        else { }

        if (obj4 != null && canChange == true)
        {
            MeshRenderer[] marr4 = obj4.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr4)
            {
                m.enabled = false;
            }
        }
        else { }

        gameobjectToZero();
    }

    private void H_Blok15_side1_angle2()
    {
        char[] temp = new char[objName.Length];
        temp = objName;

        obj1 = GameObject.Find(methodsLib.blokCoordinate(temp, 0, -1));
        obj2 = GameObject.Find(methodsLib.blokCoordinate(temp, 0, 1));
        obj3 = GameObject.Find(methodsLib.blokCoordinate(temp, 0, -2));
        obj4 = GameObject.Find(methodsLib.blokCoordinate(temp, 0, 2));

        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = false;
        }

        if (obj1 != null)
        {
            MeshRenderer[] marr1 = obj1.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr1)
            {
                m.enabled = false;
            }
        }
        else { }

        if (obj2 != null && canChange == true)
        {
            MeshRenderer[] marr2 = obj2.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr2)
            {
                m.enabled = false;
            }
        }
        else { }

        if (obj3 != null && canChange == true)
        {
            MeshRenderer[] marr3 = obj3.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr3)
            {
                m.enabled = false;
            }
        }
        else { }

        if (obj4 != null && canChange == true)
        {
            MeshRenderer[] marr4 = obj4.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr4)
            {
                m.enabled = false;
            }
        }
        else { }

        gameobjectToZero();
    }
    //-------------------------------------------------------------------------
    private void S_Blok20_side1_angle1()
    {
        char[] temp = new char[objName.Length];
        temp = objName;

        obj1 = GameObject.Find(methodsLib.blokCoordinate(temp, 0, -1));
        obj2 = GameObject.Find(methodsLib.blokCoordinate(temp, -1, 0));
        obj3 = GameObject.Find(methodsLib.blokCoordinate(temp, 1, 0));
        obj4 = GameObject.Find(methodsLib.blokCoordinate(temp, 0, 1));

        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(false);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = true;
        }

        if (obj1 != null && canChange == true)
        {
            MeshRenderer[] marr1 = obj1.GetComponentsInChildren<MeshRenderer>(false);
            foreach (MeshRenderer m in marr1)
            {
                m.enabled = true;
            }
        }
        else { }

        if (obj2 != null && canChange == true)
        {
            MeshRenderer[] marr2 = obj2.GetComponentsInChildren<MeshRenderer>(false);
            foreach (MeshRenderer m in marr2)
            {
                m.enabled = true;
            }
        }
        else { }

        if (obj3 != null && canChange == true)
        {
            MeshRenderer[] marr3 = obj3.GetComponentsInChildren<MeshRenderer>(false);
            foreach (MeshRenderer m in marr3)
            {
                m.enabled = true;
            }
        }
        else { }

        if (obj4 != null && canChange == true)
        {
            MeshRenderer[] marr4 = obj4.GetComponentsInChildren<MeshRenderer>(false);
            foreach (MeshRenderer m in marr4)
            {
                m.enabled = true;
            }
        }
        else { }

        gameobjectToZero();
    }
    private void H_Blok20_side1_angle1()
    {
        char[] temp = new char[objName.Length];
        temp = objName;

        obj1 = GameObject.Find(methodsLib.blokCoordinate(temp, 0, -1));
        obj2 = GameObject.Find(methodsLib.blokCoordinate(temp, -1, 0));
        obj3 = GameObject.Find(methodsLib.blokCoordinate(temp, 1, 0));
        obj4 = GameObject.Find(methodsLib.blokCoordinate(temp, 0, 1));

        MeshRenderer[] marr = obj.GetComponentsInChildren<MeshRenderer>(true);
        foreach (MeshRenderer m in marr)
        {
            m.enabled = false;
        }

        if (obj1 != null && canChange == true)
        {
            MeshRenderer[] marr1 = obj1.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr1)
            {
                m.enabled = false;
            }
        }
        else { }

        if (obj2 != null && canChange == true)
        {
            MeshRenderer[] marr2 = obj2.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr2)
            {
                m.enabled = false;
            }
        }
        else { }

        if (obj3 != null && canChange == true)
        {
            MeshRenderer[] marr3 = obj3.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr3)
            {
                m.enabled = false;
            }
        }
        else { }

        if (obj4 != null && canChange == true)
        {
            MeshRenderer[] marr4 = obj4.GetComponentsInChildren<MeshRenderer>(true);
            foreach (MeshRenderer m in marr4)
            {
                m.enabled = false;
            }
        }
        else { }

        gameobjectToZero();
    }
    //-------------------------------------------------------------------------
    //=========================================================================

    //=========================================================================

    //=========================================================================

    public static void setcanChange()
    {
        canChange = false;
    }
}
*/