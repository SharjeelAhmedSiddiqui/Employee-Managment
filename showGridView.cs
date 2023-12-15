using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace EMPLOY_MANGMENT
{
    class updateinfo
    {
        ListViewItem lv;
        string[] arr;
        public void showGridView(ListView data, BunifuMetroTextbox id)
        {
            //StreamReader sr = new StreamReader("log.txt");

            arr = File.ReadAllLines("log.txt");
            string[] bekar = new string[arr.Length];
            for (int i = 0, j = 0; i < arr.Length - 1; i += 10, j++)
            {


                int t = 0;
                if (arr[i] == id.Text)
                {
                    ListViewItem lvm = new ListViewItem();
                    while (t < 10)
                    {
                        //using (var sr = new StreamReader("log.txt"))
                        //{
                        //    string fileLine = sr.ReadLine();
                        //    foreach (string piece in fileLine.Split(','))
                        //    {
                        lvm.SubItems.Add(arr[i]);
                        j = -1;
                        t++;
                        i++;
                        //}
                        //sr.Close();
                        //data.Items.Add(arr[i],10);

                    }
                    data.Items.Add(lvm);
                }

            }
        }
        }
   
    }

