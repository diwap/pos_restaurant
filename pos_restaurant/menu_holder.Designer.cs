namespace pos_restaurant
{
    partial class menu_holder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.add_mennu1 = new pos_restaurant.add_mennu();
            this.menu1 = new pos_restaurant.menu();
            this.SuspendLayout();
            // 
            // add_mennu1
            // 
            this.add_mennu1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_mennu1.Location = new System.Drawing.Point(0, 0);
            this.add_mennu1.Name = "add_mennu1";
            this.add_mennu1.Size = new System.Drawing.Size(1043, 581);
            this.add_mennu1.TabIndex = 1;
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(1043, 581);
            this.menu1.TabIndex = 0;
            // 
            // menu_holder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.add_mennu1);
            this.Name = "menu_holder";
            this.Size = new System.Drawing.Size(1043, 581);
            this.ResumeLayout(false);

        }

        #endregion

        private menu menu1;
        private add_mennu add_mennu1;
    }
}
