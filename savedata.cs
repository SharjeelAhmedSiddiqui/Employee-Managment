using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Windows;
using Bunifu.Framework.UI;


namespace EMPLOY_MANGMENT
{
    class savedata
    {
        public void saveinfo(BunifuMetroTextbox  id, BunifuMetroTextbox fName, BunifuMetroTextbox name, BunifuMetroTextbox cell, BunifuMetroTextbox address, BunifuMetroTextbox cnic, BunifuMetroTextbox gender, BunifuMetroTextbox department, BunifuMetroTextbox shift, BunifuMetroTextbox basicSALARY)
        {
           
                StreamWriter userData = new StreamWriter("log.txt",true);
            userData.WriteLine(id.Text);
            userData.WriteLine(name.Text);
                userData.WriteLine(fName.Text);
                
            userData.WriteLine(cell.Text);
            userData.WriteLine(address.Text);
                userData.WriteLine(cnic.Text);
                userData.WriteLine(gender.Text);
                userData.WriteLine(department.Text);
                userData.WriteLine(shift.Text);
                userData.WriteLine(basicSALARY.Text);
           

           

                userData.Close();
              
            }
                
               
            
           
        }
    }
    

