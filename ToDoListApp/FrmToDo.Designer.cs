
namespace ToDoListApp
{
    partial class FrmToDo
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
            this.lstToDo = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstToDo
            // 
            this.lstToDo.FormattingEnabled = true;
            this.lstToDo.ItemHeight = 15;
            this.lstToDo.Location = new System.Drawing.Point(30, 84);
            this.lstToDo.Name = "lstToDo";
            this.lstToDo.Size = new System.Drawing.Size(368, 139);
            this.lstToDo.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(312, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbItem
            // 
            this.txbItem.Location = new System.Drawing.Point(30, 38);
            this.txbItem.Name = "txbItem";
            this.txbItem.Size = new System.Drawing.Size(184, 23);
            this.txbItem.TabIndex = 2;
            // 
            // FrmToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 266);
            this.Controls.Add(this.txbItem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstToDo);
            this.Name = "FrmToDo";
            this.Text = "FrmToDo";
            this.Load += new System.EventHandler(this.FrmToDo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstToDo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbItem;
    }
}