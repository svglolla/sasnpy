﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SASnPy;

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

            SASnPyHelper.PySetInputScalar("max_iter", "42", "float");
            SASnPyHelper.PySetInputScalar("some_number", "123.4567", "float");
            SASnPyHelper.PySetInputScalar("myname", "sasnpy", "str");
            SASnPyHelper.PyExecuteScript("C:/GHRepositories/sasnpy/TestScripts/pyScalarTest1.py");


            SASnPyHelper.PyEndSession();
        }

    }

}
