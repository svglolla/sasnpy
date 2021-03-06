﻿/* --------------------------------------------------------------------------------- 
 * MIT License
 * 
 * Copyright(c) 2019; Venu Gopal Lolla
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 *  
--------------------------------------------------------------------------------- */


using SASnPy;

/// <summary>
/// A helper program to test SASNPY
/// </summary>
namespace SASnPyTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //SASnPyHelper.SetPythonPath("C:/Python/Python3.6/Python.exe");
            //SASnPyHelper.ExecuteScript("C:/GHRepositories/sasnpy/TestScripts/pyFigSample2.py");

        
            //SASnPyHelper.PySetPath("C:/Python/Anaconda2/python.exe");
            SASnPyHelper.PySetPath("C:/Python/Python3.6/Python.exe");
            SASnPyHelper.PyStartSession();

            //SASnPyHelper.PyExecuteScript("C:/GHRepositories/sasnpy/TestScripts/pySample1.py");
            //SASnPyHelper.PyExecuteScript("C:/GHRepositories/sasnpy/TestScripts/pySample2.py");
            //SASnPyHelper.PyExecuteScript("C:/GHRepositories/sasnpy/TestScripts/pyFigSample1.py");

            //SASnPyHelper.PyExecuteScript("C:/GHRepositories/sasnpy/TestScripts/sessionProg1.py");
            //SASnPyHelper.PyExecuteScript("C:/GHRepositories/sasnpy/TestScripts/sessionProg2.py");
            //SASnPyHelper.PyExecuteScript("C:/GHRepositories/sasnpy/TestScripts/sessionProg3.py");

            //SASnPyHelper.PyExecuteScript("C:/GHRepositories/sasnpy/TestScripts/pyFigSample2.py");
            //SASnPyHelper.PyExecuteScript("C:/GHRepositories/sasnpy/TestScripts/pySample1.py");
            //SASnPyHelper.PyExecuteScript("C:/GHRepositories/sasnpy/TestScripts/pyFigSample1.py");
            //SASnPyHelper.PyExecuteScript("C:/GHRepositories/sasnpy/TestScripts/pyFigSample2.py");
            //SASnPyHelper.PyExecuteScript("C:/GHRepositories/sasnpy/TestScripts/pyFigSample1.py");
            //SASnPyHelper.PyExecuteScript("C:/GHRepositories/sasnpy/TestScripts/pyFigSample2.py");

            //SASnPyHelper.PySetInputScalar("p1", "23", "int");
            //SASnPyHelper.PySetInputScalar("p2", "12.34", "float");
            //SASnPyHelper.PyExecuteScript("C:/GHRepositories/sasnpy/TestScripts/sessionProg3.py");
            //string sFile1 = SASnPyHelper.PyGetOutputScalar("p2");
            //string sFile2 = SASnPyHelper.PyGetOutputScalar("p3");
            //Console.WriteLine("p2 : {0}", sFile1);
            //Console.WriteLine("p3 : {0}", sFile2);

            //SASnPyHelper.PySetInputTable("cars", "C:/Temp/cars.csv");
            //SASnPyHelper.PySetInputTable("baseball", "C:/Temp/baseball.csv");
            //SASnPyHelper.PyExecuteScript("C:/GHRepositories/sasnpy/TestScripts/pyTableTest2.py");
            //string sTableFile1 = SASnPyHelper.PyGetOutputTable("cars_dup");
            //string sTableFile2 = SASnPyHelper.PyGetOutputTable("baseball_dup");
            //Console.WriteLine("cars_dup : {0}", sTableFile1);
            //Console.WriteLine("baseball_dup : {0}", sTableFile2);

            //SASnPyHelper.PySetInputScalar("max_iter", "42", "float");
            //SASnPyHelper.PySetInputScalar("some_number", "123.4567", "float");
            //SASnPyHelper.PySetInputScalar("myname", "sasnpy", "str");

            //SASnPyHelper.PyExecuteScript("C:/GHRepositories/sasnpy/TestScripts/pyScalarTest1.py");

            ////var v1_file = SASnPyHelper.PyGetOutputScalar("some_num");
            //var v1_file = "C:/Users/svglolla/AppData/Local/Temp/SASnPyDebug/DataOut/0hitvrr0.xml";
            //var v1_type = SASnPyHelper.PyGetOutputScalarElement(v1_file, "type");
            //var v1_value = SASnPyHelper.PyGetOutputScalarElement(v1_file, "value");

            ////var v2_file = SASnPyHelper.PyGetOutputScalar("some_str");
            //var v2_file = "C:/Users/svglolla/AppData/Local/Temp/SASnPyDebug/DataOut/wrqdobwj.xml";
            //var v2_type = SASnPyHelper.PyGetOutputScalarElement(v2_file, "type");
            //var v2_value = SASnPyHelper.PyGetOutputScalarElement(v2_file, "value");

            //SASnPyHelper.PyExecuteScript("C:/GHRepositories/sasnpy/TestScripts/python/pyTimeOut1.py");

            SASnPyHelper.PyEndSession();
        }

    }

}
