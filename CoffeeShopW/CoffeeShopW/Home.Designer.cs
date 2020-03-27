namespace CoffeeShopW
{
    partial class Home
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
            this.coffeebutton = new System.Windows.Forms.Button();
            this.Promotionbutton = new System.Windows.Forms.Button();
            this.staffbutton = new System.Windows.Forms.Button();
            this.customerbutton = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coffeebutton
            // 
            this.coffeebutton.BackColor = System.Drawing.Color.BurlyWood;
            this.coffeebutton.Font = new System.Drawing.Font("Serithai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.coffeebutton.Location = new System.Drawing.Point(165, 42);
            this.coffeebutton.Name = "coffeebutton";
            this.coffeebutton.Size = new System.Drawing.Size(301, 70);
            this.coffeebutton.TabIndex = 0;
            this.coffeebutton.Text = "รายการกาแฟและเครื่องดื่ม";
            this.coffeebutton.UseVisualStyleBackColor = false;
            this.coffeebutton.Click += new System.EventHandler(this.coffeebutton_Click);
            // 
            // Promotionbutton
            // 
            this.Promotionbutton.BackColor = System.Drawing.Color.Plum;
            this.Promotionbutton.Font = new System.Drawing.Font("Serithai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Promotionbutton.Location = new System.Drawing.Point(165, 330);
            this.Promotionbutton.Name = "Promotionbutton";
            this.Promotionbutton.Size = new System.Drawing.Size(301, 70);
            this.Promotionbutton.TabIndex = 1;
            this.Promotionbutton.Text = "โปรโมชั่น";
            this.Promotionbutton.UseVisualStyleBackColor = false;
            this.Promotionbutton.Click += new System.EventHandler(this.Promotionbutton_Click);
            // 
            // staffbutton
            // 
            this.staffbutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.staffbutton.Font = new System.Drawing.Font("Serithai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.staffbutton.Location = new System.Drawing.Point(165, 133);
            this.staffbutton.Name = "staffbutton";
            this.staffbutton.Size = new System.Drawing.Size(301, 70);
            this.staffbutton.TabIndex = 2;
            this.staffbutton.Text = "รายชื่อพนักงาน";
            this.staffbutton.UseVisualStyleBackColor = false;
            this.staffbutton.Click += new System.EventHandler(this.staffbutton_Click);
            // 
            // customerbutton
            // 
            this.customerbutton.BackColor = System.Drawing.Color.Gold;
            this.customerbutton.Font = new System.Drawing.Font("Serithai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.customerbutton.Location = new System.Drawing.Point(165, 228);
            this.customerbutton.Name = "customerbutton";
            this.customerbutton.Size = new System.Drawing.Size(301, 70);
            this.customerbutton.TabIndex = 3;
            this.customerbutton.Text = "หน้าสั่งซื้อกาแฟจากลูกค้า";
            this.customerbutton.UseVisualStyleBackColor = false;
            this.customerbutton.Click += new System.EventHandler(this.customerbutton_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.BackColor = System.Drawing.Color.Red;
            this.logoutbutton.Font = new System.Drawing.Font("Serithai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.logoutbutton.Location = new System.Drawing.Point(165, 428);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(301, 70);
            this.logoutbutton.TabIndex = 4;
            this.logoutbutton.Text = "ออกจากระบบ";
            this.logoutbutton.UseVisualStyleBackColor = false;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 537);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.customerbutton);
            this.Controls.Add(this.staffbutton);
            this.Controls.Add(this.Promotionbutton);
            this.Controls.Add(this.coffeebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button coffeebutton;
        private System.Windows.Forms.Button Promotionbutton;
        private System.Windows.Forms.Button staffbutton;
        private System.Windows.Forms.Button customerbutton;
        private System.Windows.Forms.Button logoutbutton;
    }
}