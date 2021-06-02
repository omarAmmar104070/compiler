using System;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            keywords[] keyWord3Char;
            keyWord3Char = new keywords[2];
            keyWord3Char[0] = new keywords("Ity", "Integer");
            keyWord3Char[1] = new keywords("Cwq", "Character");

            //define keyWords with using array of class keyword that have 7 character
            keywords[] keyWord7Char;
            keyWord7Char = new keywords[4];
            keyWord7Char[0] = new keywords("Pattern", "Class");
            keyWord7Char[1] = new keywords("Truefor", "Condition");
            keyWord7Char[2] = new keywords("Logical", "Boolean");
            keyWord7Char[3] = new keywords("Require", "Inclusion");


            //define keyWords with using array of class keyword that have 11 character
            keywords[] keyWord11Char;
            keyWord11Char = new keywords[4];
            keyWord11Char[0] = new keywords("DerivedFrom", "Inheritance");
            keyWord11Char[1] = new keywords("CwqSequence", "String");
            keyWord11Char[2] = new keywords("RespondWith", "Return");
            keyWord11Char[3] = new keywords("ConditionOf", "Switch");

            //define keyWords with using array of class keyword that have 4 character
            keywords[] keyWord4Char;
            keyWord4Char = new keywords[4];
            keyWord4Char[0] = new keywords("Else", "Condition");
            keyWord4Char[1] = new keywords("Sity", "Sinteger");
            keyWord4Char[2] = new keywords("Srap", "Struct");
            keyWord4Char[3] = new keywords("Scan", "Switch");



            //define keyWord that have 5 character
            keywords keyWord5Char = new keywords("IfIty", "Float");

            //define keyWord that have 6 character
            keywords keyWord6Char = new keywords("SIfIty", "SFloat");

            //define keyWord that have 8 character
            keywords keyWord8Char = new keywords("Whatever", "Loop");

            //define keyWord that have 9 character
            keywords keyWord9Char = new keywords("Valueless", "Void");

            //define keyWord that have 13 character
            keywords keyWord13Char = new keywords("BreakFromThis", "Break");

            String s = "#@";
            Console.WriteLine(functions.isTookenDelimiter(s[0]));
            Console.WriteLine(functions.isTookenDelimiter(s[1]));
            StreamReader sR = new StreamReader("test.txt");
            //define line to read from file line by line 
            string line;
            int numberOfLine= 0;
            int i=0;
            //define current to know where are in the line 
            int current;
            //to know number of character in substring
            int counter = 0;

            int numberOftoken ;
            string str,identfier="ghhhko" ;
            int o=0;
            
         
            //loop to read the file kine by line
            do
            {
               //read line
                line = sR.ReadLine();
                current = 0;
                //loop for exit whin array is finish
                while (line[current]!='\n')
                {
                    str = "";
                    numberOftoken = 1;
                    //check alphapet 
                    if (functions.isAlphapet(line[current]) || line[current] == '_')
                    {
                        str += line[current++];
                         counter++;
                        //;oop for continue the word
                        while (functions.isAlphapet(line[current]) || line[current] == '_' || functions.isDigit(line[current]))

                        {
                            str += line[current++];
                            
                            counter++;
                        }
                        //check keywords
                        if (counter == 3)
                        {
                            for (int z = 0; z < 2; z++) { if (str == keyWord3Char[z].keywordName) Console.Write(numberOftoken + "\t" + str + "\t" + keyWord3Char[z].keywordMeaning); }
                            Console.Write(numberOftoken + "\t" + str + "\t" + "identfier");
                        }
                        else if (counter == 4)
                        {
                            for (int z = 0; z < 4; z++) { if (str == keyWord4Char[z].keywordName) Console.Write(numberOftoken + "\t" + str + "\t" + keyWord4Char[z].keywordMeaning); }
                            Console.Write(numberOftoken + "\t" + str + "\t" + "identfier");
                        }
                        else if (counter == 7)
                        {
                            for (int z = 0; z < 4; z++) { if (str == keyWord7Char[z].keywordName) Console.Write(numberOftoken + "\t" + str + "\t" + keyWord7Char[z].keywordMeaning); }
                            Console.Write(numberOftoken + "\t" + str + "\t" + "identfier");
                        }
                        else if (counter == 11)
                        {
                            for (int z = 0; z < 4; z++) { if (str == keyWord11Char[z].keywordName) Console.Write(numberOftoken + "\t" + str + "\t" + keyWord11Char[z].keywordMeaning); }
                            Console.Write(numberOftoken + "\t" + str + "\t" + "identfier");
                        }
                        else if (counter == 5)
                        {
                            if (str == keyWord5Char.keywordName) Console.Write(numberOftoken + "\t" + str + "\t" + keyWord5Char.keywordMeaning);
                            Console.Write(numberOftoken + "\t" + str + "\t" + "identfier");
                        }
                        else if (counter == 6)
                        {
                            if (str == keyWord6Char.keywordName) Console.Write(numberOftoken + "\t" + str + "\t" + keyWord6Char.keywordMeaning);
                            Console.Write(numberOftoken + "\t" + str + "\t" + "identfier");
                        }
                        else if (counter == 8)
                        {
                            if (str == keyWord8Char.keywordName) Console.Write(numberOftoken + "\t" + str + "\t" + keyWord8Char.keywordMeaning);
                            Console.Write(numberOftoken + "\t" + str + "\t" + "identfier");
                        }
                        else if (counter == 9)
                        {
                            if (str == keyWord9Char.keywordName) Console.Write(numberOftoken + "\t" + str + "\t" + keyWord9Char.keywordMeaning);
                            Console.Write(numberOftoken + "\t" + str + "\t" + "identfier");
                        }
                        else if (counter == 13)
                        {
                            if (str == keyWord5Char.keywordName) Console.Write(numberOftoken + "\t" + str + "\t" + keyWord5Char.keywordMeaning);
                            Console.Write(numberOftoken + "\t" + str + "\t" + "identfier");
                        }
                        //the word is not keyword but is identifier
                        else
                            Console.Write(numberOftoken + "\t" + str + "\t" + "identfier");
                        numberOftoken++;
                    }//end first if
                    //check else alphapet
                    if (functions.isBraces(line[current]))
                    {
                        current++;
                        Console.Write(numberOftoken + "\t" + str + "\t" + "braces\n");
                    }
                    else if (functions.isArithmaticOperator(line[current]))
                    {
                        current++;
                        Console.Write(numberOftoken + "\t" + str + "\t" + "ArithmaticOperator\n");
                    }
                    else if (functions.isTookenDelimiter(line[current]))
                    {
                        current++;
                        Console.Write(numberOftoken + "\t" + str + "\t" + "TookenDelimiter\n");
                    }
                    else if (functions.isStartSympol(line[current]))
                    {
                        current++;
                        Console.Write(numberOftoken + "\t" + str + "\t" + "StartSympol\n");
                    }
                    else if (functions.isEndSympol(line[current]))
                    {
                        current++;
                        Console.Write(numberOftoken + "\t" + str + "\t" + "EndSympol\n");
                    }
                    else if (functions.isQuatationMark(line[current]))
                    {
                        current++;
                        Console.Write(numberOftoken + "\t" + str + "\t" + "QuatationMark\n");
                    }
                    else if (functions.isQuatationMark(line[current]))
                    {
                        current++;
                        Console.Write(numberOftoken + "\t" + str + "\t" + "QuatationMark\n");

                    }
                    else if (functions.isLineDelimiter(line[current]))
                    {
                        current++;
                        Console.Write(numberOftoken + "\t" + str + "\t" + "lineDelimiter\n");

                    }
                    else
                        current++;
                    Console.Write(numberOftoken + "\t" + str + "\t" + "error\n");
                }


                    Console.WriteLine(line+i);

           } while (line != null);
           
        }
    }
}
