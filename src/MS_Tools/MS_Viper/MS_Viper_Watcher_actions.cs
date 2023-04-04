using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Tools.MS_Viper;
using static MS_Tools.MS_Viper.ViperTools;

namespace MS_Tools.MS_Viper
{
	/// <summary>
	/// Вспомогательный класс для работы с формой MS_Viper_Watcher из основного плагина
	/// </summary>
	public static class MS_Viper_Watcher_actions
	{
		/// <summary>
		/// Заполняет TreeNode по данным трубопровода
		/// </summary>
		/// <param name="treeView"></param>
		public static void UpdateTreeView (ref TreeView treeView)
		{
			var axis_data = ViperTools.GetAxis();
			treeView.Nodes.Clear();
			treeView.CheckBoxes = true;
			foreach (var one_axis_data in axis_data) 
			{
				TreeNode axis_node = new TreeNode(
					$"{one_axis_data.EntityName}: {one_axis_data.Element.Name}");
				foreach (var component in one_axis_data.Components)
				{
					axis_node.Nodes.Add(component.Element.Name);
				}
				treeView.Nodes.Add(axis_node);
			}
		}

		public static void RunAction (ref TreeView treeView, Work_type type, object value = null)
		{
			var axis_data = ViperTools.GetAxis();
			int counter_axises = 0;
			foreach (TreeNode node in treeView.Nodes)
			{
				if (node.Checked)
				{
					var need_axis = axis_data[counter_axises];
					foreach (var component in need_axis.Components)
					{
						dynamic component_object = null;
						/*Перебираем подключенные к оси трубопровода компоненты для изменения их толщины и связи с изоляцией*/
						if (component.ObjectName == "vCSSubSegment")
						{
							//Трубы
							component_object = component
								as vCSViperCSObjComLib.WrSubSegment;
						}
						else if (component.ObjectName == "vCSNode")
						{
							//Отводы и терминаторы. Проверяем на отвод
							component_object = component
								as vCSViperCSObjComLib.WrNodeElbow;
						}
						//Возможно, ещё какие-то объекты ...

						if (component_object != null)
						{
							WrAxisElementsActions2(component_object, type, value);
						}
					}
				}
				counter_axises++;
			}		
		}
		
	}
}
