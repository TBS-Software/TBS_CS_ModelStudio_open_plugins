using MS_Tools.MS_Viper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MS_Tools.MS_Viper.MS_Viper_Watcher_actions;
using static MS_Tools.MS_Viper.ViperTools;

namespace TBS_MS_Toolset_Fr.MS_Viper
{
	public partial class MS_Viper_Watcher : Form
	{
		public MS_Viper_Watcher()
		{
			InitializeComponent();
			MS_Viper_Watcher_actions.UpdateTreeView(ref this.ms_viper_objects_showing);

			this.base_insulation_turn_on.Checked = true;
			this.set_insulation_by_value.Checked = true;
			this.insulation_value.Text = "10";
			this.select_all.Checked = true;
			this.select_axis_by_parts.Enabled = false;
		}

		private void MS_Viper_Watcher_Load(object sender, EventArgs e)
		{

		}

		private void groupBox_ShowData_Enter(object sender, EventArgs e)
		{

		}

		private void ms_viper_objects_showing_AfterSelect(object sender, TreeViewEventArgs e)
		{

		}

		private void base_insulation_turn_on_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void base_insulation_turn_off_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void base_insulation_visiable_managing_Click(object sender, EventArgs e)
		{
			Work_type type = Work_type.Undefined;
			if (this.base_insulation_turn_on.Checked) 
				type = Work_type.EnableShowingInsulation;
			else if (this.base_insulation_turn_off.Checked)
				type = Work_type.DisableShowingInsulation;

			if (type != Work_type.Undefined) 
				RunAction(ref this.ms_viper_objects_showing, type);

		}

		private void set_insulation_by_part_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void set_insulation_by_axis_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void set_insulation_by_value_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void insulation_value_TextChanged(object sender, EventArgs e)
		{

		}

		private void insulation_value_manage_Click(object sender, EventArgs e)
		{
			Work_type type = Work_type.Undefined;
			double ins_value = 0.0;
			if (this.set_insulation_by_part.Checked)
				type = Work_type.ChangeInsulationByPart;
			else if (this.set_insulation_by_axis.Checked)
				type = Work_type.ChangeInsulationByAxis;
			else if (this.set_insulation_by_value.Checked && 
				this.insulation_value.Text != null && double.TryParse(this.insulation_value.Text, out ins_value)) 
				type = Work_type.ChangeInsulationByValue;

			if (type != Work_type.Undefined)
				RunAction(ref this.ms_viper_objects_showing, type, ins_value);
		}

		private void synhr_insulations_values_Click(object sender, EventArgs e)
		{
			RunAction(ref this.ms_viper_objects_showing, 
				Work_type.SyncroInsulationFromInsulationToParentElement);
		}

		private void select_axis_by_parts_Click(object sender, EventArgs e)
		{
			
		}

		private void select_all_CheckedChanged(object sender, EventArgs e)
		{
			foreach (TreeNode node in this.ms_viper_objects_showing.Nodes)
			{
				node.Checked = select_all.Checked;
			}
		}

		private void groupBox_insulation_visiable_Enter(object sender, EventArgs e)
		{

		}

		private void groupBox_edit_insulation_Enter(object sender, EventArgs e)
		{

		}
	}
}
