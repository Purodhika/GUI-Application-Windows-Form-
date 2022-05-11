using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purodhika_GuiPremier
{
    public partial class Form1 : Form
    {
        Dictionary<string, Premier> premiers;
        public Form1()
        {
            //constructor invokes both methods
            InitializeComponent();
            InitializeGui();
        }
        //adds each element to the dictionary 
        void InitializeGui()
        {
            premiers = new Dictionary<string, Premier>();
            foreach (var p1 in Premier.GetPremiers())
            {
                //adds each picture with list using keys
                premiers.Add(p1.GenerateKey(), p1);
            }
            //fills the datasource according to keys
            lst.DataSource = premiers.Keys.ToList();
        }
       
        private void UpdateGui(string key)
        {
            Premier premier = premiers[key];
            labelName.Text = premier.Name;  //displays key's name in the label
            labelLife.Text = premier.Life;  //displays key person's lifetime 
            labelRule.Text = premier.Start + " - " + premier.End;  //displays key person's ruling timeline
            pic.ImageLocation = @"images\" + key + ".jpg";  //locates the image from debug folder and displays in picturebox
        }
        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lst.SelectedItem.ToString();  //changes images according to the name chosen from the list box
            UpdateGui(name);
        }

    }

}
