namespace TBS_MS_Toolset_Fr.MS_Viper
{
	partial class MS_Viper_Watcher
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.ms_viper_objects_showing = new System.Windows.Forms.TreeView();
            this.groupBox_ShowData = new System.Windows.Forms.GroupBox();
            this.select_axis_by_parts = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.select_all = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_edit_insulation = new System.Windows.Forms.GroupBox();
            this.insulation_value = new System.Windows.Forms.TextBox();
            this.set_insulation_by_part = new System.Windows.Forms.RadioButton();
            this.set_insulation_by_axis = new System.Windows.Forms.RadioButton();
            this.set_insulation_by_value = new System.Windows.Forms.RadioButton();
            this.insulation_value_manage = new System.Windows.Forms.Button();
            this.groupBox_insulation_visiable = new System.Windows.Forms.GroupBox();
            this.base_insulation_visiable_managing = new System.Windows.Forms.Button();
            this.base_insulation_turn_on = new System.Windows.Forms.RadioButton();
            this.base_insulation_turn_off = new System.Windows.Forms.RadioButton();
            this.synhr_insulations_values = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_ShowData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_edit_insulation.SuspendLayout();
            this.groupBox_insulation_visiable.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отображение объектов:";
            // 
            // ms_viper_objects_showing
            // 
            this.ms_viper_objects_showing.Location = new System.Drawing.Point(6, 37);
            this.ms_viper_objects_showing.Name = "ms_viper_objects_showing";
            this.ms_viper_objects_showing.Size = new System.Drawing.Size(421, 194);
            this.ms_viper_objects_showing.TabIndex = 1;
            this.ms_viper_objects_showing.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ms_viper_objects_showing_AfterSelect);
            // 
            // groupBox_ShowData
            // 
            this.groupBox_ShowData.Controls.Add(this.select_axis_by_parts);
            this.groupBox_ShowData.Controls.Add(this.label5);
            this.groupBox_ShowData.Controls.Add(this.select_all);
            this.groupBox_ShowData.Controls.Add(this.ms_viper_objects_showing);
            this.groupBox_ShowData.Controls.Add(this.label1);
            this.groupBox_ShowData.Location = new System.Drawing.Point(12, 12);
            this.groupBox_ShowData.Name = "groupBox_ShowData";
            this.groupBox_ShowData.Size = new System.Drawing.Size(438, 277);
            this.groupBox_ShowData.TabIndex = 2;
            this.groupBox_ShowData.TabStop = false;
            this.groupBox_ShowData.Text = "Выборка объектов для изменения";
            this.groupBox_ShowData.Enter += new System.EventHandler(this.groupBox_ShowData_Enter);
            // 
            // select_axis_by_parts
            // 
            this.select_axis_by_parts.Location = new System.Drawing.Point(331, 244);
            this.select_axis_by_parts.Name = "select_axis_by_parts";
            this.select_axis_by_parts.Size = new System.Drawing.Size(75, 23);
            this.select_axis_by_parts.TabIndex = 4;
            this.select_axis_by_parts.Text = "Выбрать";
            this.select_axis_by_parts.UseVisualStyleBackColor = true;
            this.select_axis_by_parts.Click += new System.EventHandler(this.select_axis_by_parts_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Нажмите для выбора осей по \r\nотдельным объектам из модели";
            // 
            // select_all
            // 
            this.select_all.AutoSize = true;
            this.select_all.Location = new System.Drawing.Point(8, 244);
            this.select_all.Name = "select_all";
            this.select_all.Size = new System.Drawing.Size(112, 17);
            this.select_all.TabIndex = 2;
            this.select_all.Text = "Выбрать все оси";
            this.select_all.UseVisualStyleBackColor = true;
            this.select_all.CheckedChanged += new System.EventHandler(this.select_all_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox_edit_insulation);
            this.groupBox1.Controls.Add(this.groupBox_insulation_visiable);
            this.groupBox1.Controls.Add(this.synhr_insulations_values);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(456, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 277);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Команды для работы с данными";
            // 
            // groupBox_edit_insulation
            // 
            this.groupBox_edit_insulation.Controls.Add(this.insulation_value);
            this.groupBox_edit_insulation.Controls.Add(this.set_insulation_by_part);
            this.groupBox_edit_insulation.Controls.Add(this.set_insulation_by_axis);
            this.groupBox_edit_insulation.Controls.Add(this.set_insulation_by_value);
            this.groupBox_edit_insulation.Controls.Add(this.insulation_value_manage);
            this.groupBox_edit_insulation.Location = new System.Drawing.Point(6, 83);
            this.groupBox_edit_insulation.Name = "groupBox_edit_insulation";
            this.groupBox_edit_insulation.Size = new System.Drawing.Size(317, 119);
            this.groupBox_edit_insulation.TabIndex = 15;
            this.groupBox_edit_insulation.TabStop = false;
            this.groupBox_edit_insulation.Text = "Изменение толщины изоляции у элементов:";
            this.groupBox_edit_insulation.Enter += new System.EventHandler(this.groupBox_edit_insulation_Enter);
            // 
            // insulation_value
            // 
            this.insulation_value.Location = new System.Drawing.Point(124, 60);
            this.insulation_value.Name = "insulation_value";
            this.insulation_value.Size = new System.Drawing.Size(187, 20);
            this.insulation_value.TabIndex = 8;
            this.insulation_value.TextChanged += new System.EventHandler(this.insulation_value_TextChanged);
            // 
            // set_insulation_by_part
            // 
            this.set_insulation_by_part.AutoSize = true;
            this.set_insulation_by_part.Location = new System.Drawing.Point(27, 15);
            this.set_insulation_by_part.Name = "set_insulation_by_part";
            this.set_insulation_by_part.Size = new System.Drawing.Size(171, 17);
            this.set_insulation_by_part.TabIndex = 5;
            this.set_insulation_by_part.TabStop = true;
            this.set_insulation_by_part.Text = "По родительскому элементу";
            this.set_insulation_by_part.UseVisualStyleBackColor = true;
            this.set_insulation_by_part.CheckedChanged += new System.EventHandler(this.set_insulation_by_part_CheckedChanged);
            // 
            // set_insulation_by_axis
            // 
            this.set_insulation_by_axis.AutoSize = true;
            this.set_insulation_by_axis.Location = new System.Drawing.Point(27, 38);
            this.set_insulation_by_axis.Name = "set_insulation_by_axis";
            this.set_insulation_by_axis.Size = new System.Drawing.Size(133, 17);
            this.set_insulation_by_axis.TabIndex = 6;
            this.set_insulation_by_axis.TabStop = true;
            this.set_insulation_by_axis.Text = "По оси трубопровода";
            this.set_insulation_by_axis.UseVisualStyleBackColor = true;
            this.set_insulation_by_axis.CheckedChanged += new System.EventHandler(this.set_insulation_by_axis_CheckedChanged);
            // 
            // set_insulation_by_value
            // 
            this.set_insulation_by_value.AutoSize = true;
            this.set_insulation_by_value.Location = new System.Drawing.Point(27, 61);
            this.set_insulation_by_value.Name = "set_insulation_by_value";
            this.set_insulation_by_value.Size = new System.Drawing.Size(91, 17);
            this.set_insulation_by_value.TabIndex = 7;
            this.set_insulation_by_value.TabStop = true;
            this.set_insulation_by_value.Text = "По значению";
            this.set_insulation_by_value.UseVisualStyleBackColor = true;
            this.set_insulation_by_value.CheckedChanged += new System.EventHandler(this.set_insulation_by_value_CheckedChanged);
            // 
            // insulation_value_manage
            // 
            this.insulation_value_manage.Location = new System.Drawing.Point(236, 86);
            this.insulation_value_manage.Name = "insulation_value_manage";
            this.insulation_value_manage.Size = new System.Drawing.Size(75, 23);
            this.insulation_value_manage.TabIndex = 9;
            this.insulation_value_manage.Text = "Применить";
            this.insulation_value_manage.UseVisualStyleBackColor = true;
            this.insulation_value_manage.Click += new System.EventHandler(this.insulation_value_manage_Click);
            // 
            // groupBox_insulation_visiable
            // 
            this.groupBox_insulation_visiable.Controls.Add(this.base_insulation_visiable_managing);
            this.groupBox_insulation_visiable.Controls.Add(this.base_insulation_turn_on);
            this.groupBox_insulation_visiable.Controls.Add(this.base_insulation_turn_off);
            this.groupBox_insulation_visiable.Location = new System.Drawing.Point(6, 24);
            this.groupBox_insulation_visiable.Name = "groupBox_insulation_visiable";
            this.groupBox_insulation_visiable.Size = new System.Drawing.Size(317, 53);
            this.groupBox_insulation_visiable.TabIndex = 14;
            this.groupBox_insulation_visiable.TabStop = false;
            this.groupBox_insulation_visiable.Text = "Управление видимостью базовой изоляции";
            this.groupBox_insulation_visiable.Enter += new System.EventHandler(this.groupBox_insulation_visiable_Enter);
            // 
            // base_insulation_visiable_managing
            // 
            this.base_insulation_visiable_managing.Location = new System.Drawing.Point(236, 19);
            this.base_insulation_visiable_managing.Name = "base_insulation_visiable_managing";
            this.base_insulation_visiable_managing.Size = new System.Drawing.Size(75, 23);
            this.base_insulation_visiable_managing.TabIndex = 3;
            this.base_insulation_visiable_managing.Text = "Применить";
            this.base_insulation_visiable_managing.UseVisualStyleBackColor = true;
            this.base_insulation_visiable_managing.Click += new System.EventHandler(this.base_insulation_visiable_managing_Click);
            // 
            // base_insulation_turn_on
            // 
            this.base_insulation_turn_on.AutoSize = true;
            this.base_insulation_turn_on.Location = new System.Drawing.Point(16, 22);
            this.base_insulation_turn_on.Name = "base_insulation_turn_on";
            this.base_insulation_turn_on.Size = new System.Drawing.Size(74, 17);
            this.base_insulation_turn_on.TabIndex = 1;
            this.base_insulation_turn_on.TabStop = true;
            this.base_insulation_turn_on.Text = "Включить";
            this.base_insulation_turn_on.UseVisualStyleBackColor = true;
            this.base_insulation_turn_on.CheckedChanged += new System.EventHandler(this.base_insulation_turn_on_CheckedChanged);
            // 
            // base_insulation_turn_off
            // 
            this.base_insulation_turn_off.AutoSize = true;
            this.base_insulation_turn_off.Location = new System.Drawing.Point(96, 22);
            this.base_insulation_turn_off.Name = "base_insulation_turn_off";
            this.base_insulation_turn_off.Size = new System.Drawing.Size(82, 17);
            this.base_insulation_turn_off.TabIndex = 2;
            this.base_insulation_turn_off.TabStop = true;
            this.base_insulation_turn_off.Text = "Выключить";
            this.base_insulation_turn_off.UseVisualStyleBackColor = true;
            this.base_insulation_turn_off.CheckedChanged += new System.EventHandler(this.base_insulation_turn_off_CheckedChanged);
            // 
            // synhr_insulations_values
            // 
            this.synhr_insulations_values.Location = new System.Drawing.Point(242, 244);
            this.synhr_insulations_values.Name = "synhr_insulations_values";
            this.synhr_insulations_values.Size = new System.Drawing.Size(75, 23);
            this.synhr_insulations_values.TabIndex = 13;
            this.synhr_insulations_values.Text = "Применить";
            this.synhr_insulations_values.UseVisualStyleBackColor = true;
            this.synhr_insulations_values.Click += new System.EventHandler(this.synhr_insulations_values_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "Синхронизировать значения изоляции между \r\nэлементом Изоляции и атрибутом \"родите" +
    "ля\"\r\n(не работает)";
            // 
            // MS_Viper_Watcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(794, 303);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_ShowData);
            this.Name = "MS_Viper_Watcher";
            this.Text = "Конфигуратор модели MS Трубопроводы";
            this.Load += new System.EventHandler(this.MS_Viper_Watcher_Load);
            this.groupBox_ShowData.ResumeLayout(false);
            this.groupBox_ShowData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_edit_insulation.ResumeLayout(false);
            this.groupBox_edit_insulation.PerformLayout();
            this.groupBox_insulation_visiable.ResumeLayout(false);
            this.groupBox_insulation_visiable.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TreeView ms_viper_objects_showing;
		private System.Windows.Forms.GroupBox groupBox_ShowData;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox select_all;
		private System.Windows.Forms.Button base_insulation_visiable_managing;
		private System.Windows.Forms.RadioButton base_insulation_turn_off;
		private System.Windows.Forms.RadioButton base_insulation_turn_on;
		private System.Windows.Forms.RadioButton set_insulation_by_part;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button insulation_value_manage;
		private System.Windows.Forms.TextBox insulation_value;
		private System.Windows.Forms.RadioButton set_insulation_by_value;
		private System.Windows.Forms.RadioButton set_insulation_by_axis;
		private System.Windows.Forms.Button synhr_insulations_values;
		private System.Windows.Forms.Button select_axis_by_parts;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox_insulation_visiable;
		private System.Windows.Forms.GroupBox groupBox_edit_insulation;
	}
}