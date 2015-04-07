﻿using CLScriptExt;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTest;
namespace UnitTestDll
{
    //原来C#LightTestor的部分
    public class ExpTest_10
    {
        //只要有一个静态函数包含UnitTest名称的，就作为单元测试
        public static object UnitTest_1001()
        {
            //1001 _1001_expression
            return 1 + 2 > 3 / 4;

        }
        public static object UnitTest_1002()
        {
            //1002 _1002_expression

            int a = (int)(Math.Pow(1.4f, 5) * 5f);

            Vector3 v3 = new Vector3((252.0f / 255.0f), (207.0f / 255.0f), (20.0f / 255.0f));
            Logger.Log("v3=" + v3);
            return (2 + 55) * 3434;

        }
        public static object UnitTest_1003()
        {
            //1003 _1003_expression
            return 1 + 2 * 2 + 55 * 3434 + (2 - 3) - (3 - 3) + 5;

        }
        public static object UnitTest_1004()
        {
            //1004 _1004_expression
            string a = "abc";
            string b = "abd";

            return "str=" + a + b;

        }
        public static object UnitTest_1005()
        {
            float s = 0.2f;
            if (s <= 0f || s >= 2f)
            {
                Logger.Log(""+1);
            }
            else
            {
                Logger.Log(""+2);
            }
            return 1;
        }

        public static void UnitTest_1006()
        {
            byte b = 11;
            b.ToString();
        }
    }
}
