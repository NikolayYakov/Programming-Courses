
namespace AddRemovePerson
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addPerson = new System.Windows.Forms.Button();
            this.removePerson = new System.Windows.Forms.Button();
            this.listPeople = new System.Windows.Forms.ListBox();
            this.textPerson = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ListOfPersons";
            // 
            // addPerson
            // 
            this.addPerson.Location = new System.Drawing.Point(211, 247);
            this.addPerson.Name = "addPerson";
            this.addPerson.Size = new System.Drawing.Size(94, 29);
            this.addPerson.TabIndex = 2;
            this.addPerson.Text = "Add";
            this.addPerson.UseVisualStyleBackColor = true;
            this.addPerson.Click += new System.EventHandler(this.addPerson_Click);
            // 
            // removePerson
            // 
            this.removePerson.Location = new System.Drawing.Point(111, 247);
            this.removePerson.Name = "removePerson";
            this.removePerson.Size = new System.Drawing.Size(94, 29);
            this.removePerson.TabIndex = 3;
            this.removePerson.Text = "Remove";
            this.removePerson.UseVisualStyleBackColor = true;
            this.removePerson.Click += new System.EventHandler(this.removePerson_Click);
            // 
            // listPeople
            // 
            this.listPeople.FormattingEnabled = true;
            this.listPeople.ItemHeight = 20;
            this.listPeople.Location = new System.Drawing.Point(-1, 77);
            this.listPeople.Name = "listPeople";
            this.listPeople.Size = new System.Drawing.Size(306, 164);
            this.listPeople.TabIndex = 4;
            // 
            // textPerson
            // 
            this.textPerson.Location = new System.Drawing.Point(0, 24);
            this.textPerson.Name = "textPerson";
            this.textPerson.Size = new System.Drawing.Size(305, 27);
            this.textPerson.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.textPerson);
            this.Controls.Add(this.listPeople);
            this.Controls.Add(this.removePerson);
            this.Controls.Add(this.addPerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addPerson;
        private System.Windows.Forms.Button removePerson;
        private System.Windows.Forms.ListBox listPeople;
        private System.Windows.Forms.TextBox textPerson;
    }
}

