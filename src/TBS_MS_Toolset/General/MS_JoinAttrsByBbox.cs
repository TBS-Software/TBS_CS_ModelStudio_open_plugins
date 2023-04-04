using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MS_Tools.General.JoinAttrsByBbox;


namespace TBS_MS_Toolset.General
{
    public partial class MS_JoinAttrsByBbox : Form
    {
        private MS_Tools.General.JoinAttrsByBbox _actions;
        public MS_JoinAttrsByBbox()
        {
            InitializeComponent();
            _actions = new MS_Tools.General.JoinAttrsByBbox();
        }


        private void select_group_1_Click(object sender, EventArgs e)
        {
            _actions.AddToGroup(GroupElements.First);
        }

        private void select_group_2_Click(object sender, EventArgs e)
        {
            _actions.AddToGroup(GroupElements.Second);
            //Обновляем список актрибутов в окошке
        }

        private void run_procedure_Click(object sender, EventArgs e)
        {

        }

        private void type_of_checking_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prefix_atts_names_TextChanged(object sender, EventArgs e)
        {

        }

        private void show_attrs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void use_names_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
