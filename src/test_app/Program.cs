using MS_Tools;
using System;
using static MS_Tools.MS_Viper.ViperTools;

namespace test_app
{
	internal class Program
	{
		static void Main(string[] args)
		{
			test();
			Console.WriteLine("End!");
			Console.ReadKey();
		}
		static void test()
		{
			var ms_space = GeneralTools.CurrentDoc2().ModelSpace;
			foreach (dynamic item in ms_space)
			{
				if (GeneralTools.IsMsObject(item))
				{
					var ms_element = item.Element;
					Console.WriteLine(ms_element.Name);

					if (ms_element.Name == "Помещение")
					{
						double[] min_point = new double[3];
						double[] max_point = new double[3];

                        var ext = item.GetBoundingBox(min_point, max_point);
						Console.Write("Ок");
					}
				}
			}

		}
	}
}