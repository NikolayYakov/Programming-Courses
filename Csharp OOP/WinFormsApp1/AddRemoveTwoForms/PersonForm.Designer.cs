
namespace AddRemoveTwoForms
{
    partial class PersonForm
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
            this.okBButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okBButton
            // 
            this.okBButton.Location = new System.Drawing.Point(224, 117);
            this.okBButton.Name = "okBButton";
            this.okBButton.Size = new System.Drawing.Size(94, 29);
            this.okBButton.TabIndex = 0;
            this.okBButton.Text = "OK";
            this.okBButton.UseVisualStyleBackColor = true;
            this.okBButton.Click += new System.EventHandler(this.okBButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Person Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Person Number";
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(0, 84);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(318, 27);
            this.textNumber.TabIndex = 3;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(0, 31);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(318, 27);
            this.textName.TabIndex = 4;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okBButton);
            this.Name = "PersonForm";
            this.Text = "Person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textName;
    }
}