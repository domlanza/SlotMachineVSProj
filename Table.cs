using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SlotMachineGame_Drafts_Lanza
{
    //Written by Rodney Drafts and Dominic Lanza
    //Class: Table Class 
    //Class Description: This creates the table to consitute a win in the slot machine
    public class Table
    {
        //Dictionary object used to associate keys and values
        private Dictionary<String, String> keyValuePairs = new Dictionary<String, string>();
        private List<String> keys = new List<String>();
        private List<String> values = new List<string>();
        

        //Default Constructor that creates table on creation of Table object
        public Table()
        {
            create();
        }


        //creates the dictionary object that holds winning slot combinations in table
        private void create()
        {
            String x1 = "000";
            String x2 = "111";
            String x3 = "333";
            String x4 = "222";
            String x5 = "233";
            String x6 = "332";
            String x7 = "133";
            String x8 = "331";
            String x9 = "112";
            String x10 = "223";
            String x11 = "221";
            String x12 = "220";
            String x13 = "022";
            String x14 = "110";
            String x15 = "131";
            String x16 = "311";
            String x17 = "313";

            keys.Add(x1);
            keys.Add(x2);
            keys.Add(x3);
            keys.Add(x4);
            keys.Add(x5);
            keys.Add(x6);
            keys.Add(x7);
            keys.Add(x8);
            keys.Add(x9);
            keys.Add(x10);
            keys.Add(x11);
            keys.Add(x12);
            keys.Add(x13);
            keys.Add(x14);
            keys.Add(x15);
            keys.Add(x16);
            keys.Add(x17);


            string[] mon = { "5", "20", "300" , "777", "10", "2",  "15", "12", "5", "1", "15" , "5", "20", "3", "1", "3", "30" };
            foreach (string x in mon)
            {
                values.Add(x);
            }

            for (int i = 0; i < 11; i++)
            {
                keyValuePairs.Add(keys[i], values[i]);
                
            }
           
        }

        
        //returns int value to caller if key present in dictionary object
        public int isWinner(int[] slotstops)
        {
            string result = string.Join("", slotstops);
            if (keyValuePairs.ContainsKey(result))
            {
                string val = keyValuePairs[result];
                int num = Convert.ToInt32(val);
                MessageBox.Show("you won");
                return num;
            }

            return 0;
        }

      
    }
}
