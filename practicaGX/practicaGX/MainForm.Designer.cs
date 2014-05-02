/*
 * Creado por SharpDevelop.
 * Usuario: Alumnos
 * Fecha: 02/05/2014
 * Hora: 09:55 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace practicaGX
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Nombre = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(42, 54);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(178, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// Nombre
			// 
			this.Nombre.Location = new System.Drawing.Point(42, 28);
			this.Nombre.Name = "Nombre";
			this.Nombre.Size = new System.Drawing.Size(100, 23);
			this.Nombre.TabIndex = 1;
			this.Nombre.Text = "Nombre";
			this.Nombre.Click += new System.EventHandler(this.Label1Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(339, 54);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(207, 20);
			this.textBox2.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(343, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Codigo";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(25, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(242, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "1.- Numero de Estados  de la Republica Mexicana";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(25, 160);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(204, 34);
			this.label1.TabIndex = 6;
			this.label1.Text = "2.- Paises que forman los paises aliados  durante la segunda Guerra Mundial";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(25, 206);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(104, 24);
			this.checkBox1.TabIndex = 7;
			this.checkBox1.Text = "Rusia ";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(25, 236);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(104, 24);
			this.checkBox2.TabIndex = 8;
			this.checkBox2.Text = "Japón";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(25, 266);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(104, 24);
			this.checkBox3.TabIndex = 9;
			this.checkBox3.Text = "Alemania";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			this.checkBox4.Location = new System.Drawing.Point(25, 296);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(104, 24);
			this.checkBox4.TabIndex = 10;
			this.checkBox4.Text = "Reino Unido";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(339, 99);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(220, 36);
			this.label4.TabIndex = 11;
			this.label4.Text = "3.- Dictador de Italia durante la Segunda Guerra Mundial";
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(339, 140);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 12;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Musoolini";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(339, 170);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 13;
			this.radioButton2.Text = "Yu gi oh";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(339, 200);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(104, 24);
			this.radioButton3.TabIndex = 14;
			this.radioButton3.Text = "Hitler";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(42, 125);
			this.numericUpDown1.Maximum = new decimal(new int[] {
									35,
									0,
									0,
									0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(339, 236);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(207, 23);
			this.label5.TabIndex = 16;
			this.label5.Text = "4.- En que continete se encuentra Peru?";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"Asia",
									"Africa",
									"America",
									"Oceanía",
									"Europa"});
			this.comboBox1.Location = new System.Drawing.Point(356, 263);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(356, 296);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(139, 23);
			this.label6.TabIndex = 18;
			this.label6.Text = "fecha del Grito de Dolores";
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(356, 323);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 19;
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Location = new System.Drawing.Point(25, 387);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(159, 73);
			this.button1.TabIndex = 20;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(627, 504);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.Nombre);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "practicaGX";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label Nombre;
		private System.Windows.Forms.TextBox textBox1;
	}
}
