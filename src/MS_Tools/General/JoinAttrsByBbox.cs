using OdaX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teigha.DatabaseServices;

namespace MS_Tools.General
{
    /// <summary>
    /// Передача группе объектов значения свойста из группы других объектов по условиям:
    /// полное вхождение, частичное вхождение, невхождение.
    /// Работаем только с представлением BoundingBox. Более тонкие настройки в зависимости от отдельных ModelStudio
    /// будут реализованы потом
    /// </summary>
    public class JoinAttrsByBbox
    {
        private GeometryMode mode;
        private List<AcadEntity> ents_1 = null;
        private List<AcadEntity> ents_2 = null;
        public List<string> moved_prop_names = null;
        public bool move_name_need = false;
        public string prefix_props = "";
        public void AddToGroup (GroupElements group)
        {
            if (group == GroupElements.First) ents_1 = GeneralTools.SelectEntities(true);
            else if (group == GroupElements.Second) ents_2 = GeneralTools.SelectEntities(true);
        }
        //public JoinAttrsByBbox (GeometryMode mode)
        //{
        //    this.mode = mode;
        //}
        public enum GeometryMode : int
        {
            /// <summary>
            /// Элемент из второй группы полностью содержит в себе элемент из первой группы 
            /// </summary>
            Contains,
            /// <summary>
            /// Элемент из второй группы полностью содержит в себе элемент из первой группы
            /// или допускает частичное попадание в границы
            /// </summary>
            Crosses_or_contains,
            /// <summary>
            /// Элемент из второй группы не содержит в себе элемент из первой группы даже частично
            /// </summary>
            Non_contains
        }
        /// <summary>
        /// Нумератор группы элементов
        /// </summary>
        public enum GroupElements : int
        {
            First,
            Second
        }
        public void JoinAttrsByMode (GeometryMode mode)
        {
            //Проверяем элементы
            if (ents_1 == null | ents_2 == null)
            {
                GeneralTools.CurrentDoc.Utility.Prompt("Не были выбраны группы объектов," +
                    " либо выборка не содержит объектов Model Studio");

                return;
            }
            //Составляем дерево из BBOX второй группы
            Dictionary<ObjectId, Extents3d> objects_bbox = new Dictionary<ObjectId, Extents3d>();

        }
        /// <summary>
        /// Добавляет имена параметров в линкованный ListBox
        /// </summary>
        /// <param name="lb"></param>
        public void ShowAttrs(ref ListBox lb)
        {
            if (this.ents_2 == null) 
            {
                GeneralTools.CurrentDoc.Utility.Prompt("Не были выбраны группы объектов," +
                    " либо выборка не содержит объектов Model Studio");
                return;
            }
            List<string> param_names = new List<string>();
            foreach (var el in this.ents_2)
            {
                mdsUnitsLib.Element ms_element = el as mdsUnitsLib.Element;
                foreach (mdsUnitsLib.parameter param in ms_element.Parameters)
                {
                    if (!param_names.Contains(param.Name)) param_names.Add(param.Name);
                }
            }
            if (param_names.Any())
            {
                foreach (string param_name in param_names) { lb.Items.Add(param_name); }
            }
        }

    }
}
