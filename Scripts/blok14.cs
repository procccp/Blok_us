﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blok14
{
    public coordinate[] requireToChange(int side, int angle, coordinate co)
    {
        coordinate[] coo = new coordinate[5];
        coo[0] = co;
        if (side == 1 && (angle == 1 || angle == 3))
        {
            coo[1] = StaticMethodLib.onlyDoOffset(co, -1, 0);
            coo[2] = StaticMethodLib.onlyDoOffset(co, -1, -1);
            coo[3] = StaticMethodLib.onlyDoOffset(co, 1, 0);
            coo[4] = StaticMethodLib.onlyDoOffset(co, 1, 1);
        }
        else if (side == 1 && (angle == 2 || angle == 4))
        {
            coo[1] = StaticMethodLib.onlyDoOffset(co, 0, 1);
            coo[2] = StaticMethodLib.onlyDoOffset(co, -1, 1);
            coo[3] = StaticMethodLib.onlyDoOffset(co, 0, -1);
            coo[4] = StaticMethodLib.onlyDoOffset(co, 1, -1);
        }
        else if (side == 2 && (angle == 1 || angle == 3))
        {
            coo[1] = StaticMethodLib.onlyDoOffset(co, 1, 0);
            coo[2] = StaticMethodLib.onlyDoOffset(co, -1, 0);
            coo[3] = StaticMethodLib.onlyDoOffset(co, 1, -1);
            coo[4] = StaticMethodLib.onlyDoOffset(co, -1, 1);
        }
        else if (side == 2 && (angle == 2 || angle == 4))
        {
            coo[1] = StaticMethodLib.onlyDoOffset(co, 0, -1);
            coo[2] = StaticMethodLib.onlyDoOffset(co, 0, 1);
            coo[3] = StaticMethodLib.onlyDoOffset(co, -1, -1);
            coo[4] = StaticMethodLib.onlyDoOffset(co, 1, 1);
        }

        return coo;
    }
}