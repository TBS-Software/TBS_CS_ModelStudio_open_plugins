using MS_Tools;
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
            this.mode_3d.Checked = true;
            this.type_of_checking.SelectionMode = SelectionMode.One;
            this.show_attrs.SelectionMode = SelectionMode.MultiExtended;
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
            //Куча проверок условий допустимости старта :(

            //Учитывать ли имена
            if (this.use_names.Checked) this._actions.move_name_need= true;
            else this._actions.move_name_need = false;

            if (this.show_attrs.Items.Count > 0)
            {
                //Берём список наименований
                if (this.show_attrs.SelectedItems.Count == 0)
                {
                    //exception
                    GeneralTools.CurrentDocNet.Editor.WriteMessage(
                    "Отсутствуют выделенные свойства для передачи");
                    if (this._actions.move_name_need == false)
                    {
                        return;
                    }
                }
                else
                {
                    List<string> names = new List<string>();
                    foreach (var selected_name in this.show_attrs.SelectedItems)
                    {
                        names.Add(selected_name.ToString());
                    }
                    this._actions.moved_prop_names = names;
                }
            }
            else if (this._actions.move_name_need == false)
            {
                GeneralTools.CurrentDocNet.Editor.WriteMessage(
                    "Отсутствуют параметры для передачи" +
                    " или не выбран режим \" Использовать атрибут по имени элемента\"");
                return;
            }
            //Префикс для добавляемых свойств
            if (this.prefix_atts_names.Text.Length > 0)
                this._actions.prefix_props = this.prefix_atts_names.Text;
            //Режим координат
            if (this.mode_2d.Checked) this._actions.coord_mode = CoordinatesMode.Mode_2d;
            else if (this.mode_3d.Checked) this._actions.coord_mode = CoordinatesMode.Mode_3d;
            //как учитывать геометрию
            if (this.type_of_checking.SelectedIndex == 0) 
                this._actions.mode = GeometryMode.Contains;
            else if (this.type_of_checking.SelectedIndex == 1)
                this._actions.mode = GeometryMode.Crosses_or_contains;

            this._actions.JoinAttrsByMode();

            //this.Close();

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

        private void mode_3d_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mode_2d_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
