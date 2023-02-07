﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum_Generics
{
    internal class Test_Maximum
    {
        public static int IntMaxnum(int firstValue, int secondValue, int thirdValue)
        {
            if( firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >0 )
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            return firstValue;
        }
        public static float floatMaxnum(float firstValue, float secondValue, float thirdValue)
        {
            if( firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >0 )
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            return firstValue;
        }
    }
}
