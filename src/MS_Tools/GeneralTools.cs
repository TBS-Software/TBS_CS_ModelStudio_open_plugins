using HostMgd.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using OdaX;
using Teigha.DatabaseServices;
using HostMgd.EditorInput;

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

		/// <summary>
		/// Выборка объектов модели
		/// </summary>
		/// <param name="is_ms">True: только объекты MS; False - все объекты</param>
		/// <returns></returns>
		public static List<AcadEntity> SelectEntities(bool is_ms = true)
		{
            List<AcadEntity> acad_ents = new List<AcadEntity>(); 

            var nc_doc = CurrentDocNet;
            using (DocumentLock acDocLock = nc_doc.LockDocument())
            {
                using (Transaction acTrans = nc_doc.Database.TransactionManager.StartTransaction())
                {
                    BlockTable acBlkTbl = acTrans.GetObject(nc_doc.Database.BlockTableId,
                                                    OpenMode.ForRead) as BlockTable;

                    PromptSelectionResult acSSPrompt = nc_doc.Editor.GetSelection();
                    if (acSSPrompt.Status == PromptStatus.OK)
					{
                        SelectionSet acSSet = acSSPrompt.Value;
                        foreach (SelectedObject acSSObj in acSSet)
                        {
                            // Check to make sure a valid SelectedObject object was returned
                            if (acSSObj != null)
                            {
								var db_obj = acTrans.GetObject(acSSObj.ObjectId, OpenMode.ForRead);
                                if (db_obj != null)
								{
									var com_obj = db_obj.AcadObject as AcadEntity;
									if (com_obj != null)
									{
										if (is_ms)
										{
											if (IsMsObject(com_obj)) acad_ents.Add(com_obj);
											else acad_ents.Add(com_obj);
                                        }
									}
								}
                            }
                        }
                    }
					acTrans.Commit();
                }
            }
			return acad_ents;
        }
	}
}
