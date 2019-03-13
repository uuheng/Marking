namespace Marking
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(72, 187);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(77, 25);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(72, 239);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(77, 25);
			this.textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(72, 286);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(77, 25);
			this.textBox3.TabIndex = 2;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(72, 341);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(77, 25);
			this.textBox4.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(41, 190);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "ν";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 249);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(22, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "γ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(41, 296);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "ξ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(40, 344);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(15, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "K";
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(418, 65);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(595, 445);
			this.listView1.TabIndex = 8;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(44, 65);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(199, 23);
			this.comboBox1.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(31, 29);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 15);
			this.label5.TabIndex = 10;
			this.label5.Text = " 选择数据库：";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(72, 494);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(89, 36);
			this.button1.TabIndex = 11;
			this.button1.Text = "添加水印";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(266, 494);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(89, 36);
			this.button2.TabIndex = 12;
			this.button2.Text = "水印检测";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(250, 351);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(22, 15);
			this.label6.TabIndex = 13;
			this.label6.Text = "α";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(278, 344);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(77, 25);
			this.textBox5.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(415, 29);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 15);
			this.label7.TabIndex = 15;
			this.label7.Text = "数据预览：";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1054, 562);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Marking";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label7;
	}
}

