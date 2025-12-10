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


        private void updateLiveFilterView()
        {
            
        }

        // returns a panel with the name of the filter
        private FlowLayoutPanel createFilter(string name)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                Name = name,
                Height = 28,
                WrapContents = false,
                AutoSize = true,
            };

            Button delete = new Button
            {
                Size = new Size { Height = 20, Width = 20 },
                Text = "×",
            };

            Label lbl = new Label
            {
                Text = name,
                Name = name,
            };

            panel.Controls.Add(delete);
            panel.Controls.Add(lbl);

            return panel;
        }

        private void AddFilter_click(object sender, EventArgs e)
        {
            Control addButton = filterList.Controls[filterList.Controls.Count - 1];
            Control p = createFilter(filterNameBox.Text);

            filterList.Controls.Remove(addButton);
            filterList.Controls.Add(p);
            filterList.Controls.Add(addButton);
        }


    }
}
