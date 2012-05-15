using System;
using System.IO;

using System.Collections.Generic;
using System.Text;
using System.Threading;
using Microsoft.WindowsMobile.Samples.Location;


namespace ML_Forest
{
    public class Plot
    {
        Stack[] undoStack;
        int[,] count;
        string[] siteClass;
        public int plotNum, standNum;
        public string station, comment, regenType;
        private Boolean[] regen;

        static Gps gps;
        static GpsPosition gpsPosition;
        public double longitude, latitude;

        public const int SPECIES_COUNT = 17;

        //Some constants to make the code more readable
        public const int SAP_SC = 0;
        public const int POLEWOOD = 1;
        public const int SMALL = 2;
        public const int MEDIUM = 3;
        public const int LARGE = 4;

        //All sepcies with AGS size
        public const int Pw_AGS = 0;
        public const int Pr_AGS = 1;
        public const int He_AGS = 2;
        public const int Sw_AGS = 3;
        public const int Ce_AGS = 4;
        public const int Bf_AGS = 5;
        public const int Lt_AGS = 6;
        public const int Mh_AGS = 7;
        public const int Ms_AGS = 8;
        public const int Or_AGS = 9;
        public const int Be_AGS = 10;
        public const int Bd_AGS = 11;
        public const int Aw_AGS = 12;
        public const int By_AGS = 13;
        public const int Iw_AGS = 14;
        public const int Po_AGS = 15;
        public const int Bw_AGS = 16;

        //All species with UGS size
        public const int Pw_UGS = 17;
        public const int Pr_UGS = 18;
        public const int He_UGS = 19;
        public const int Sw_UGS = 20;
        public const int Ce_UGS = 21;
        public const int Bf_UGS = 22;
        public const int Lt_UGS = 23;
        public const int Mh_UGS = 24;
        public const int Ms_UGS = 25;
        public const int Or_UGS = 26;
        public const int Be_UGS = 27;
        public const int Bd_UGS = 28;
        public const int Aw_UGS = 29;
        public const int By_UGS = 30;
        public const int Iw_UGS = 31;
        public const int Po_UGS = 32;
        public const int Bw_UGS = 33;

        public Plot(int stand, int plot)
        {
            pollGPS();

            plotNum = plot;
            standNum = stand;
            undoStack = new Stack[5];

            regen = new Boolean[SPECIES_COUNT];
            for (int i = 0; i < SPECIES_COUNT; i++)
            {
                regen[i] = false;
            }

            //Initialize the stacks and the matrix to all 0's
            count = new int[5, SPECIES_COUNT*2];
            for (int i = 0; i < 5; i++)
            {
                undoStack[i] = new Stack(15);
                for (int j = 0; j < SPECIES_COUNT*2; j++)
                {
                    count[i, j] = 0;
                }
            }

            //Initialize the array of age/height (site class)
            siteClass = new string[SPECIES_COUNT];
            for (int i = 0; i < SPECIES_COUNT; i++)
            {
                siteClass[i] = "";
            }
        }

        public void pollGPS()
        {
            gps = new Gps();
            gps.Open();

            gpsPosition = gps.GetPosition();

            //while (!gpsPosition.LatitudeValid || !gpsPosition.LatitudeValid)
                //Thread.Sleep(500);

            gps.Close();

            latitude = gpsPosition.Latitude;
            longitude = gpsPosition.Longitude;
        }

        public int getCount(int sizeCategory, int species)
        {
            return count[sizeCategory, species];
        }

        public void toggleRegen(int species)
        {
            regen[species] = !regen[species];
        }

        public void setSiteClass(int species, string age, string height)
        {
            siteClass[species] = age + "/" + height;
        }

        public string getSiteClass(int species)
        {
            return siteClass[species];
        }

        //This function increments the proper count and returns the new value.
        public int increment(int sizeCategory, int species)
        {
            count[sizeCategory, species]++;
            undoStack[sizeCategory].push(species);
            return count[sizeCategory, species];
        }

        //This function undoes the last change made in the given size category.
        //**The form code is responsible for updating the UI.
        public void undo(int sizeCategory)
        {
            //stack.pop() returns -1 if there is nothing to pop.
            int species = undoStack[sizeCategory].pop();
            if (species > -1) count[sizeCategory, species]--;
        }

        public void exportFile()
        {
            CurrentStand.save();

            writeCountCSV("Polewood", POLEWOOD);
            writeCountCSV("Small", SMALL);
            writeCountCSV("Medium", MEDIUM);
            writeCountCSV("Large", LARGE);

            writeExtraCSV();
        }

        private void writeCountCSV(string sizeCategory, int correspondingTab)
        {
            String path = "\\My Documents\\"+ sizeCategory +".csv";

            if (!File.Exists(path))
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write("standNum,plotNum,Pw_AGS,Pr_AGS,He_AGS,Sw_AGS,Ce_AGS,Bf_AGS,Lt_AGS,Mh_AGS,Ms_AGS,Or_AGS,Be_AGS,Bd_AGS,Aw_AGS,By_AGS,Iw_AGS,Po_AGS,Bw_AGS,Pw_UGS,Pr_UGS,He_UGS,Sw_UGS,Ce_UGS,Bf_UGS,Lt_UGS,Mh_UGS,Ms_UGS,Or_UGS,Be_UGS,Bd_UGS,Aw_UGS,By_UGS,Iw_UGS,Po_UGS,Bw_UGS");
                writer.WriteLine();
                }
            }

            using (StreamWriter writer = File.AppendText(path))
            {
                writer.Write(standNum.ToString() + ",");
                writer.Write(plotNum.ToString() + ",");

                int i = correspondingTab;
                for (int j = 0; j < SPECIES_COUNT*2; j++)
                {
                    writer.Write(count[i, j].ToString() + ",");
                }

                writer.WriteLine();
            }
        }

        private void writeExtraCSV()
        {
            String path = "\\My Documents\\Extra.csv";

            if (!File.Exists(path))
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write("standNum,plotNum,longitude,latitude,station,comment,regenString,regenType,Pw_Sap,Pr_Sap,Sw_Sap,He_Sap,Ce_Sap,Bf_Sap,Lt_Sap,Mh_Sap,Ms_Sap,Or_Sap,Be_Sap,Bd_Sap,Aw_Sap,By_Sap,Iw_Sap,Po_Sap,Bw_Sap,Pw_SC,Pr_SC,Sw_SC,He_SC,Ce_SC,Bf_SC,Lt_SC,Mh_SC,Ms_SC,Or_SC,Be_SC,Bd_SC,Aw_SC,By_SC,Iw_SC,Po_SC,Bw_SC");
                    writer.WriteLine();
                }
            }


            using (StreamWriter writer = File.AppendText(path))
            {
                writer.Write(standNum.ToString() + ",");
                writer.Write(plotNum.ToString() + ",");

                writer.Write(longitude.ToString() + ",");
                writer.Write(latitude.ToString() + ",");
                writer.Write(station + ",");
                writer.Write(comment + ",");

                string regenString = getRegen();

                writer.Write(regenString +",");
                writer.Write(regenType + ",");

                for (int j = 0; j < SPECIES_COUNT; j++)
                {
                    writer.Write(count[SAP_SC, j].ToString() + ",");
                }

                for (int i = 0; i < SPECIES_COUNT-1; i++)
                {
                    writer.Write(siteClass[i] + ",");
                }

                writer.Write(siteClass[SPECIES_COUNT - 1]);
                writer.WriteLine();
            }
        }

        private string getRegen()
        {
            string regenString = "";

            for (int i = 0; i < SPECIES_COUNT; i++)
            {
                if (regen[i])
                {
                    switch (i)
                    {
                        case Pw_AGS:
                            regenString += "Pw ";
                            break;
                        case Pr_AGS:
                            regenString += "Pr ";
                            break;
                        case Sw_AGS:
                            regenString += "Sw ";
                            break;
                        case He_AGS:
                            regenString += "He ";
                            break;
                        case Ce_AGS:
                            regenString += "Ce ";
                            break;
                        case Bf_AGS:
                            regenString += "Bf ";
                            break;
                        case Lt_AGS:
                            regenString += "Lt ";
                            break;
                        case Mh_AGS:
                            regenString += "Mh ";
                            break;
                        case Or_AGS:
                            regenString += "Or /w ";
                            break;
                        case Be_AGS:
                            regenString += "Be ";
                            break;
                        case Bd_AGS:
                            regenString += "Bd ";
                            break;
                        case Aw_AGS:
                            regenString += "Aw /b ";
                            break;
                        case By_AGS:
                            regenString += "By ";
                            break;
                        case Iw_AGS:
                            regenString += "Iw ";
                            break;
                        case Po_AGS:
                            regenString += "Po ";
                            break;
                        case Bw_AGS:
                            regenString += "Bw ";
                            break;
                    }
                }
            }
            return regenString.Trim();
        }

    }
}
