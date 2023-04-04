using static MS_Tools.MS_Viper.ViperTools;

using HostMgd.ApplicationServices;
using HostMgd.EditorInput;
using HostMgd.Runtime;
using Teigha.Runtime;
using System.Windows.Forms;
using MS_Tools;

namespace TBS_MS_Toolset_Fr
{
	/// <summary>
	/// Загрузчик методов в ModelStudio
	/// </summary>
	public class Loader
	{

		#region MS_Трубопроводы
		/// <summary>
		/// Изменить отображение изоляции
		/// </summary>
		[CommandMethod("TBS_MS_Viper_RunConfigurator")]
		public void TBS_MS_Viper_RunConfigurator()
		{
			//check license
			Form configurator = new MS_Viper.MS_Viper_Watcher();
			HostMgd.ApplicationServices.Application.ShowModalDialog(configurator);
		}

		#endregion
	}
}