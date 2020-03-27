namespace CoffeeShopW
{
    partial class Staff
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
            this.button1 = new System.Windows.Forms.Button();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.Showstaffbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Serithai", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(-5, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(879, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "รายชื่อพนักงาน";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Serithai", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(664, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 78);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GridView1
            // 
            this.GridView1.BackgroundColor = System.Drawing.Color.White;
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Location = new System.Drawing.Point(31, 179);
            this.GridView1.Name = "GridView1";
            this.GridView1.RowHeadersWidth = 51;
            this.GridView1.RowTemplate.Height = 24;
            this.GridView1.Size = new System.Drawing.Size(809, 233);
            this.GridView1.TabIndex = 3;
            this.GridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView1_CellContentClick);
            // 
            // Showstaffbutton
            // 
            this.Showstaffbutton.BackColor = System.Drawing.Color.Chartreuse;
            this.Showstaffbutton.Font = new System.Drawing.Font("Serithai", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Showstaffbutton.Location = new System.Drawing.Point(31, 76);
            this.Showstaffbutton.Name = "Showstaffbutton";
            this.Showstaffbutton.Size = new System.Drawing.Size(176, 78);
            this.Showstaffbutton.TabIndex = 4;
            this.Showstaffbutton.Text = "Show Staff";
            this.Showstaffbutton.UseVisualStyleBackColor = false;
            this.Showstaffbutton.Click += new System.EventHandler(this.Showstaffbutton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Font = new System.Drawing.Font("Serithai", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(322, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 78);
            this.button2.TabIndex = 5;
            this.button2.Text = "ลบ staff";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 564);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Showstaffbutton);
            this.Controls.Add(this.GridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Staff";
            this.Text = "Staff";
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.Button Showstaffbutton;
        private System.Windows.Forms.Button button2;
    }
}