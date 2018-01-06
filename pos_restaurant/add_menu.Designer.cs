namespace pos_restaurant
{
    partial class add_menu
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
            this.name = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(41, 16);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(323, 20);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(41, 81);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(323, 20);
            this.category.TabIndex = 0;
            this.category.Text = "Category";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(41, 145);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(323, 20);
            this.price.TabIndex = 0;
            this.price.Text = "Price";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(41, 208);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(165, 38);
            this.save.TabIndex = 1;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            // 
            // add_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.save);
            this.Controls.Add(this.price);
            this.Controls.Add(this.category);
            this.Controls.Add(this.name);
            this.Name = "add_menu";
            this.Size = new System.Drawing.Size(1043, 581);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button save;
    }
}
