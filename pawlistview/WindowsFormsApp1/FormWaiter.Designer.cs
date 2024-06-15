namespace WindowsFormsApp1
{
    partial class FormWaiter
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
            this.components = new System.ComponentModel.Container();
            this.textboxnume = new System.Windows.Forms.TextBox();
            this.textBoxsalariu = new System.Windows.Forms.TextBox();
            this.checkboxestefull = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxnume
            // 
            this.textboxnume.Location = new System.Drawing.Point(307, 68);
            this.textboxnume.Name = "textboxnume";
            this.textboxnume.Size = new System.Drawing.Size(100, 26);
            this.textboxnume.TabIndex = 0;
            this.textboxnume.Validating += new System.ComponentModel.CancelEventHandler(this.textboxnume_Validating);
            this.textboxnume.Validated += new System.EventHandler(this.textboxnume_Validated);
            // 
            // textBoxsalariu
            // 
            this.textBoxsalariu.Location = new System.Drawing.Point(307, 150);
            this.textBoxsalariu.Name = "textBoxsalariu";
            this.textBoxsalariu.Size = new System.Drawing.Size(109, 26);
            this.textBoxsalariu.TabIndex = 1;
            // 
            // checkboxestefull
            // 
            this.checkboxestefull.AutoSize = true;
            this.checkboxestefull.Location = new System.Drawing.Point(310, 238);
            this.checkboxestefull.Name = "checkboxestefull";
            this.checkboxestefull.Size = new System.Drawing.Size(86, 24);
            this.checkboxestefull.TabIndex = 2;
            this.checkboxestefull.Text = "estefull";
            this.checkboxestefull.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdd.Location = new System.Drawing.Point(557, 202);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(153, 88);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add new waiter";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormWaiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkboxestefull);
            this.Controls.Add(this.textBoxsalariu);
            this.Controls.Add(this.textboxnume);
            this.Name = "FormWaiter";
            this.Text = "FormWaiter";
            this.Load += new System.EventHandler(this.FormWaiter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxnume;
        private System.Windows.Forms.TextBox textBoxsalariu;
        private System.Windows.Forms.CheckBox checkboxestefull;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}