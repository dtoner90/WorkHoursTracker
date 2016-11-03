using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Work_Hours_Tracker
{
    class Funcs
    {
        public static bool ImportFile(DataGridView gridIn, String Path)
        {
            try
            {
                String textLine = string.Empty;
                String[] splitLine;

                // clear the grid view

                gridIn.Rows.Clear();

                if (File.Exists(Path))
                {
                    StreamReader objReader = new StreamReader(Path);
   
                    do
                    {
                        textLine = objReader.ReadLine();
                        
                        if (textLine != "")
                        {
                            splitLine = textLine.Replace("\"", "").Split(',');

                            if (splitLine[0] != "" || splitLine[1] != "")
                            {
                                gridIn.Rows.Add(splitLine);

                            }
                        }

                    } while (objReader.Peek() != -1);
                    objReader.Close();
                }
                int get = gridIn.Rows.Count;

                gridIn.Rows.Remove(gridIn.Rows[0]); // remove row that contains the headers
                
                return true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file"))
                {
                    MessageBox.Show("The file you are importing is open.", "Work Hours Tracker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }

                return false;
            }
        }
    }
}
