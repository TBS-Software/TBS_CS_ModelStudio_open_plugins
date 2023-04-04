namespace TBS_MS_Toolset.General
{
    partial class MS_JoinAttrsByBbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MS_JoinAttrsByBbox));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.select_group_1 = new System.Windows.Forms.Button();
            this.select_group_2 = new System.Windows.Forms.Button();
            this.type_of_checking = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.run_procedure = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.show_attrs = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.prefix_atts_names = new System.Windows.Forms.TextBox();
            this.use_names = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите объекты первой группы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выберите объекты второй группы:";
            // 
            // select_group_1
            // 
            this.select_group_1.Location = new System.Drawing.Point(217, 76);
            this.select_group_1.Name = "select_group_1";
            this.select_group_1.Size = new System.Drawing.Size(75, 23);
            this.select_group_1.TabIndex = 3;
            this.select_group_1.Text = "Выбрать";
            this.select_group_1.UseVisualStyleBackColor = true;
            this.select_group_1.Click += new System.EventHandler(this.select_group_1_Click);
            // 
            // select_group_2
            // 
            this.select_group_2.Location = new System.Drawing.Point(217, 111);
            this.select_group_2.Name = "select_group_2";
            this.select_group_2.Size = new System.Drawing.Size(75, 23);
            this.select_group_2.TabIndex = 4;
            this.select_group_2.Text = "Выбрать";
            this.select_group_2.UseVisualStyleBackColor = true;
            this.select_group_2.Click += new System.EventHandler(this.select_group_2_Click);
            // 
            // type_of_checking
            // 
            this.type_of_checking.FormattingEnabled = true;
            this.type_of_checking.Items.AddRange(new object[] {
            "Первый объект находится полностью в составе второго",
            "Первый объект находится частично в составе второго",
            "Первый объект не входит ни в один из объектов второго"});
            this.type_of_checking.Location = new System.Drawing.Point(15, 170);
            this.type_of_checking.Name = "type_of_checking";
            this.type_of_checking.Size = new System.Drawing.Size(307, 95);
            this.type_of_checking.TabIndex = 5;
            this.type_of_checking.SelectedIndexChanged += new System.EventHandler(this.type_of_checking_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Выберите режим проверки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Нажмите для старта процедуры сопоставления:";
            // 
            // run_procedure
            // 
            this.run_procedure.Location = new System.Drawing.Point(283, 275);
            this.run_procedure.Name = "run_procedure";
            this.run_procedure.Size = new System.Drawing.Size(75, 23);
            this.run_procedure.TabIndex = 8;
            this.run_procedure.Text = "Начать";
            this.run_procedure.UseVisualStyleBackColor = true;
            this.run_procedure.Click += new System.EventHandler(this.run_procedure_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Выберите атрибуты из второй группы \r\nдля передачи в атрибуты первой группы:";
            // 
            // show_attrs
            // 
            this.show_attrs.FormattingEnabled = true;
            this.show_attrs.Location = new System.Drawing.Point(396, 49);
            this.show_attrs.Name = "show_attrs";
            this.show_attrs.Size = new System.Drawing.Size(309, 212);
            this.show_attrs.TabIndex = 10;
            this.show_attrs.SelectedIndexChanged += new System.EventHandler(this.show_attrs_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Префикс для добавляемых атрибутов:";
            // 
            // prefix_atts_names
            // 
            this.prefix_atts_names.Location = new System.Drawing.Point(602, 272);
            this.prefix_atts_names.Name = "prefix_atts_names";
            this.prefix_atts_names.Size = new System.Drawing.Size(103, 20);
            this.prefix_atts_names.TabIndex = 12;
            this.prefix_atts_names.TextChanged += new System.EventHandler(this.prefix_atts_names_TextChanged);
            // 
            // use_names
            // 
            this.use_names.AutoSize = true;
            this.use_names.Location = new System.Drawing.Point(396, 301);
            this.use_names.Name = "use_names";
            this.use_names.Size = new System.Drawing.Size(243, 17);
            this.use_names.TabIndex = 13;
            this.use_names.Text = "Использовать атрибут по имени элемента";
            this.use_names.UseVisualStyleBackColor = true;
            this.use_names.CheckedChanged += new System.EventHandler(this.use_names_CheckedChanged);
            // 
            // MS_JoinAttrsByBbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(723, 374);
            this.Controls.Add(this.use_names);
            this.Controls.Add(this.prefix_atts_names);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.show_attrs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.run_procedure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.type_of_checking);
            this.Controls.Add(this.select_group_2);
            this.Controls.Add(this.select_group_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MS_JoinAttrsByBbox";
            this.Text = "Настройка передаваемых параметров между группами объектов ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button select_group_1;
        private System.Windows.Forms.Button select_group_2;
        private System.Windows.Forms.ListBox type_of_checking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button run_procedure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox show_attrs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox prefix_atts_names;
        private System.Windows.Forms.CheckBox use_names;
    }
}