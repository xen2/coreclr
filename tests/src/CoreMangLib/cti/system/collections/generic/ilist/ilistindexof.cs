using System;
using System.Collections.Generic;
/// <summary>
///IList
/// </summary>
public class IListIndexOf
{
    public static int Main()
    {
        IListIndexOf IListIndexOf = new IListIndexOf();
        TestLibrary.TestFramework.BeginTestCase("IListIndexOf");
        if (IListIndexOf.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;

        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        retVal = PosTest3() && retVal;
        retVal = PosTest4() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Calling indexof method ,T is value type. ");
        try
        {
            IList<int> myList = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                myList.Add(i * 100);
            }
            int expectValue = 2;
            int actualValue = myList.IndexOf(300);
            if (actualValue != expectValue)
            {
                TestLibrary.TestFramework.LogError("001.1", "Calling IndexOf method return a value correctly.");
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest2()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest2: Calling indexof method ,T is reference type. ");
        try
        {
            IList<string> myList = new List<string>();
            for (int i = 1; i <= 10; i++)
            {
                myList.Add(i.ToString());
            }
            int expectValue = 2;
            int actualValue = myList.IndexOf("3");
            if (actualValue != expectValue)
            {
                TestLibrary.TestFramework.LogError("002.1", "Calling IndexOf method return a value correctly.");
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002.0", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }

    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest3()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest3: Calling indexof method ,T is user define type. ");
        try
        {
            IList<MyTestClass> myList = new List<MyTestClass>();
            MyTestClass myTest = null;
            for (int i = 1; i <= 10; i++)
            {
                myTest = new MyTestClass();
                myTest.ID = i;
                myList.Add(myTest);
            }
            int expectValue = 9;
            int actualValue = myList.IndexOf(myTest);
            if (actualValue != expectValue)
            {
                TestLibrary.TestFramework.LogError("003.1", "Calling IndexOf method return a value correctly.");
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("003.0", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }

    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest4()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest4: Calling indexof method ,T is user define type,the item is not exist int the List. ");
        try
        {
            IList<MyTestClass> myList = new List<MyTestClass>();
            MyTestClass myTest = null;
            for (int i = 1; i <= 10; i++)
            {
                myTest = new MyTestClass();
                myTest.ID = i;
                myList.Add(myTest);
            }
            int expectValue = -1;
            myTest = new MyTestClass();
            myTest.ID = 100;
            int actualValue = myList.IndexOf(myTest);
            if (actualValue != expectValue)
            {
                TestLibrary.TestFramework.LogError("004.1", "Calling IndexOf method return a value correctly.");
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("004.0", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
}
public class MyTestClass
{
    private int id = 0;
    public MyTestClass()
    {

    }
    public int ID
    {
        get { return this.id; }
        set { this.id = value; }
    }

}
