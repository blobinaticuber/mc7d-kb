using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static _3dedit.Keybindings;

namespace _3dedit.src
{
    public partial class FilterSetup : Form
    {
        Filters filters;
        public FilterSetup(Filters filters)
        {
            InitializeComponent();
            this.filters = filters;

            // initialize filter buttton bg colors to puzzle colors
            this.f_col1.BackColor = Color.FromArgb((int)CubeObj.Colors[1]);
            this.f_col2.BackColor = Color.FromArgb((int)CubeObj.Colors[2]);
            this.f_col3.BackColor = Color.FromArgb((int)CubeObj.Colors[3]);
            this.f_col4.BackColor = Color.FromArgb((int)CubeObj.Colors[4]);
            this.f_col5.BackColor = Color.FromArgb((int)CubeObj.Colors[5]);
            this.f_col6.BackColor = Color.FromArgb((int)CubeObj.Colors[6]);
            this.f_col7.BackColor = Color.FromArgb((int)CubeObj.Colors[7]);
            this.f_col8.BackColor = Color.FromArgb((int)CubeObj.Colors[8]);
            this.f_col9.BackColor = Color.FromArgb((int)CubeObj.Colors[9]);
            this.f_col10.BackColor = Color.FromArgb((int)CubeObj.Colors[10]);
            this.f_col11.BackColor = Color.FromArgb((int)CubeObj.Colors[11]);
            this.f_col12.BackColor = Color.FromArgb((int)CubeObj.Colors[12]);
            this.f_col13.BackColor = Color.FromArgb((int)CubeObj.Colors[13]);
            this.f_col14.BackColor = Color.FromArgb((int)CubeObj.Colors[14]);
        }

        private void createButton(string name)
        {
            //Button btn = new Button();
            //btn.Text = name;
            //btn.Name = name;
            //btn.Click += new System.EventHandler(this.SwitchLayout_Click);
            //btn.Width = addNewLayout.Width;

            Label lbl = new Label();
            lbl.Text = name;
            lbl.Name = name;

            this.flowLayoutPanel2.Controls.Add(lbl);
        }

        private void AddNewLayout_Click(object sender, EventArgs e)
        {
            TextDialog td = new TextDialog("Enter Layout Name");
            DialogResult res = td.ShowDialog(this);
            if (res.Equals(DialogResult.OK))
            {
                string name = td.Value.Replace(' ', '_').Replace(',', '_');
                    createButton(name);
                
            }
        }


    }
}
