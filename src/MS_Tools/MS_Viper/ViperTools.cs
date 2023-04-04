using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MS_Tools.GeneralTools;

namespace MS_Tools.MS_Viper
{
	/// <summary>
	/// Работа с MS Трубопроводы
	/// </summary>
	public static class ViperTools
	{
		public enum Work_type
		{
			Undefined = 0,
			DisableShowingInsulation = 1,
			EnableShowingInsulation = 2,
			ChangeInsulationByAxis = 3,
			ChangeInsulationByPart = 4,
			ChangeInsulationOfPartsByAxis = 5,
			ChangeInsulationByValue = 6,
			SyncroInsulationFromInsulationToParentElement = 7
		}
		internal static void WrAxisElementsActions2(dynamic component_object,
			Work_type type, object value = null)
		{
			var nc_doc = CurrentDoc;

			//Управление отображением дефолтной изоляции
			if (type == Work_type.DisableShowingInsulation)
			{
				component_object.Axis_Insulation_Disableview = true;
				component_object.Part_Insulation_Disableview = true;
			}

			else if (type == Work_type.EnableShowingInsulation)
			{
				component_object.Axis_Insulation_Disableview = false;
				component_object.Part_Insulation_Disableview = false;
			}
			//Управление величиной изоляции
			else if (type == Work_type.ChangeInsulationOfPartsByAxis |
				type == Work_type.ChangeInsulationByPart |
				type == Work_type.ChangeInsulationByAxis |
				type == Work_type.ChangeInsulationByValue | 
				type == Work_type.SyncroInsulationFromInsulationToParentElement)
			{
				//Это фактически пока недоступно и требует осмысления корректности и потребности
				if (type == Work_type.ChangeInsulationOfPartsByAxis)
				{
					var current_iso_2 = component_object.Axis_Insulation_Thickness;
					if (current_iso_2 > 0) component_object.PartPipe_Thickness =
						component_object.Axis_Insulation_Thickness.ToString();
				}
				else
				{
					if (component_object.HasInsulation)
					{
						dynamic insulation_instance = component_object.Insulation;

						var current_iso_1 = component_object.PartPipe_Thickness;
						double current_iso_1_d;
						bool current_iso_1_check = Double.TryParse(current_iso_1, out current_iso_1_d);

						var current_iso_2 = component_object.Axis_Insulation_Thickness;

						if (type == Work_type.ChangeInsulationByPart && current_iso_1_check)
							insulation_instance.Thickness = current_iso_1_d;
						else if (type == Work_type.ChangeInsulationByAxis && current_iso_2 > 0)
							component_object.Insulation.Thickness = current_iso_2;
						//Задание изоляции конкретной величины
						else if (type == Work_type.ChangeInsulationByValue && value != null)
						{
							double value_as_d;
							if (Double.TryParse(value.ToString(), out value_as_d)) insulation_instance.Thickness = value_as_d;
						}
						else if (type == Work_type.SyncroInsulationFromInsulationToParentElement)
						{
							component_object.PartPipe_Thickness = insulation_instance.Thickness;
						}
						else
						{
							nc_doc.Utility.Prompt($"У элемента " +
								$"{component_object.Part_Name} величина изоляции для оси или трубы = 0");
						}
					}
					else
					{
						nc_doc.Utility.Prompt($"У элемента " +
							$"{component_object.Part_Name} отсутствует изоляция!");
					}
				}
			}
		}
		
		/// <summary>
		/// Возвращает набор осей трубопроводов из модели в виде интерфейсов оси и её элементов
		/// </summary>
		/// <returns></returns>
		public static List<vCSViperCSObjComLib.WrAxis> GetAxis()
		{
			var nc_doc = CurrentDoc;
			List<vCSViperCSObjComLib.WrAxis> data =
				new List<vCSViperCSObjComLib.WrAxis>();
			foreach (dynamic model_object in nc_doc.ModelSpace)
			{
				if (IsMsObject(model_object))
				{
					/*Для объектов типа "Ось трубопровода" 
					 перебираем все элементы и для них задаем нужные данные*/
					if (model_object.ObjectName == "vCSAxis")
					{
						var as_axis = model_object as vCSViperCSObjComLib.WrAxis;
						data.Add(as_axis);
					}
				}
			}
			return data;
		}
	}
}
