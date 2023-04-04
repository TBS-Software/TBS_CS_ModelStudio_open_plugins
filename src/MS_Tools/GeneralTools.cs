using HostMgd.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MS_Tools
{
	/// <summary>
	/// Разные общие инструменты работы с COM
	/// </summary>
	public static class GeneralTools
	{
		/// <summary>
		/// Приведение текущего документа к интерфейсу nanoCAD.Document
		/// </summary>
		public static nanoCAD.Document CurrentDoc =>
			HostMgd.ApplicationServices.Application.
				DocumentManager.MdiActiveDocument.AcadDocument as
				nanoCAD.Document;
		public static Document CurrentDocNet => HostMgd.ApplicationServices.Application.
				DocumentManager.MdiActiveDocument;

		public static nanoCAD.Document CurrentDoc2()
		{
			var app = Marshal.GetActiveObject("nanoCADx64.Application.22.0") as
			nanoCAD.Application;
			return app.ActiveDocument;
		}


		/// <summary>
		/// Проверка, является ли данный объект объектом модели ModelStudio
		/// </summary>
		/// <param name="checking_object"></param>
		/// <returns></returns>
		public static bool IsMsObject(dynamic checking_object)
		{
			try
			{
				var el = checking_object.Element;
				if (el != null) { return true; }
				else return false;
			}
			catch { }
			return false;
		}

	}
}
