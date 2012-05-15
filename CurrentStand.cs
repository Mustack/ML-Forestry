using System;
using System.IO;

using System.Collections.Generic;
using System.Text;

namespace ML_Forest
{
    static class CurrentStand
    {
        public static int standNum = 1;
        public static int plotNum = 1;
        public static string block = "";
        public static string twp = "";
        public static string date = "";
        public static string history = "";
        public static string standOperator = "";
        public static string soil = "";
        public static string ecosite = "";
        public static string plantsObserved = "";

        public static Boolean isChanged = false;
        public static Boolean isLastStand = true;

        private const string filePath = "\\My Documents\\Stands.csv";

        public static Boolean isComplete()
        {
            if (block.Length > 0 &&
                twp.Length > 0 &&
                standOperator.Length > 0)
            {
                return true;
            }

            return false;
        }

        public static void newStand()
        {
            save();

            standNum++;
            block = "";
            twp = "";
            date = DateTime.Today.ToString();
            history = "";
            standOperator = "";
            soil = "";
            ecosite = "";
            plantsObserved = "";

            isLastStand = true;

            save();
        }

        public static Boolean nextStand()
        {
            isLastStand = loadStand(standNum + 1);
            return isLastStand;
        }

        public static void previousStand()
        {
            if (standNum != 1)
            {
                loadStand(standNum - 1);
                isLastStand = false;
            }
        }

        public static void save()
        {
            if (isChanged)
            {
                writeToFile();
                isChanged = false;
            }
        }

        //This function loads the requested stand from csv and returns
        //a boolean of whether this stand is the last one or not.
        public static Boolean loadStand(int newStandNum)
        {
            if (!File.Exists(filePath))
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("standNum,date,operator,block,twp,history,soil,ecosite,plantsObserved,nextPlot");
                }
                standNum--;
                newStand();
                isChanged = true;
            }

            //first save any possible changes
            save();

            using (StreamReader reader = File.OpenText(filePath))
            {
                string s = "";
                while ((s = reader.ReadLine()) != null)
                {
                    if (s.Substring(0,1) == newStandNum.ToString())
                        break;
                }

                string[] info = new string[10];
                info = s.Split(',');

                standNum = Convert.ToInt16(info[0]);
                date = info[1];
                standOperator = info[2];
                block = info[3];
                twp = info[4];
                history = info[5];
                soil = info[6];
                ecosite = info[7];
                plantsObserved = info[8];
                plotNum = Convert.ToInt16(info[9]);

                isLastStand = (reader.ReadLine() == null);
                return isLastStand;
            }
        }

        private static void writeToFile()
        {
            int lineNum = 0;
            if ((lineNum = standAlreadyExists()) > -1)
            {
                replaceLine(lineNum);
            } else {
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(getStandInfo());
                }
                isLastStand = true;
            }
        }

        //This function rebuilds the csv file to replace the line for the current stand
        //and put the updated information in it.
        private static void replaceLine(int lineNum)
        {
            string[] lines = new string[30];
            lines[29] = "$";

            using (StreamReader reader = File.OpenText(filePath))
            {
                string s = "";
                for (int i = 0; i < lines.Length-1; i++)
                {
                    if (i == lineNum)
                    {
                        lines[i] = getStandInfo();
                        reader.ReadLine();
                    }
                    else if ((s = reader.ReadLine()) == null)
                    {
                        lines[i] = "$";
                        break;
                    }
                    else
                    {
                        lines[i] = s;
                    }
                }
            }

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    int i = 0;
                    while (lines[i] != "$")
                    {
                        writer.WriteLine(lines[i]);
                        i++;
                    }
                }
            }

        private static string getStandInfo()
        {
            string info =
                    standNum.ToString() + "," +
                    date + "," +
                    standOperator + "," +
                    block + "," +
                    twp + "," +
                    history + "," +
                    soil + "," +
                    ecosite + "," +
                    plantsObserved + "," +
                    plotNum.ToString();

            return info;
        }

        //This function checks if the current stand is already in the file and returns
        //the line number that it is found in.
        private static int standAlreadyExists()
        {
            using (StreamReader reader = File.OpenText(filePath))
            {
                string s = "";
                int i = 0;

                while ((s = reader.ReadLine()) != null)
                {
                    if (s.Substring(0,1) == standNum.ToString())
                        return i;
                    i++;
                }

                return -1;
            }
        }
    }
}
