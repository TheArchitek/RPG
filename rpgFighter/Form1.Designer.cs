namespace rpgFighter
{
    partial class Form1
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
            this.rtb_console = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAlliance = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rtbCharList = new System.Windows.Forms.RichTextBox();
            this.btItems = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCharName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbItemDescription = new System.Windows.Forms.RichTextBox();
            this.tbMaxCapacity = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_console
            // 
            this.rtb_console.BackColor = System.Drawing.SystemColors.WindowText;
            this.rtb_console.ForeColor = System.Drawing.Color.Chartreuse;
            this.rtb_console.Location = new System.Drawing.Point(322, 248);
            this.rtb_console.Name = "rtb_console";
            this.rtb_console.Size = new System.Drawing.Size(300, 115);
            this.rtb_console.TabIndex = 0;
            this.rtb_console.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Fighter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(62, 24);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(232, 20);
            this.tbName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Allignment";
            // 
            // cbAlliance
            // 
            this.cbAlliance.AutoSize = true;
            this.cbAlliance.Checked = true;
            this.cbAlliance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAlliance.Location = new System.Drawing.Point(110, 57);
            this.cbAlliance.Name = "cbAlliance";
            this.cbAlliance.Size = new System.Drawing.Size(52, 17);
            this.cbAlliance.TabIndex = 5;
            this.cbAlliance.Text = "Good";
            this.cbAlliance.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbAlliance);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Design";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Output Char List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rtbCharList
            // 
            this.rtbCharList.Location = new System.Drawing.Point(16, 183);
            this.rtbCharList.Name = "rtbCharList";
            this.rtbCharList.Size = new System.Drawing.Size(300, 182);
            this.rtbCharList.TabIndex = 7;
            this.rtbCharList.Text = "";
            // 
            // btItems
            // 
            this.btItems.Location = new System.Drawing.Point(9, 201);
            this.btItems.Name = "btItems";
            this.btItems.Size = new System.Drawing.Size(268, 23);
            this.btItems.TabIndex = 6;
            this.btItems.Text = "Add Equipment";
            this.btItems.UseVisualStyleBackColor = true;
            this.btItems.Click += new System.EventHandler(this.btItems_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.storageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(628, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(175, 349);
            this.dataGridView1.TabIndex = 9;
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataSource = typeof(rpgFighter.Utilities.Storage);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbMaxCapacity);
            this.groupBox2.Controls.Add(this.rtbItemDescription);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btItems);
            this.groupBox2.Controls.Add(this.cbCharName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbValue);
            this.groupBox2.Controls.Add(this.tbWeight);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbItemName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(322, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 230);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipment Design";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(84, 106);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(193, 20);
            this.tbValue.TabIndex = 8;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(84, 77);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(193, 20);
            this.tbWeight.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Equipment Name";
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(84, 50);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(193, 20);
            this.tbItemName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Weight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Character";
            // 
            // cbCharName
            // 
            this.cbCharName.FormattingEnabled = true;
            this.cbCharName.Location = new System.Drawing.Point(84, 23);
            this.cbCharName.Name = "cbCharName";
            this.cbCharName.Size = new System.Drawing.Size(193, 21);
            this.cbCharName.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Description";
            // 
            // rtbItemDescription
            // 
            this.rtbItemDescription.Location = new System.Drawing.Point(84, 171);
            this.rtbItemDescription.Name = "rtbItemDescription";
            this.rtbItemDescription.Size = new System.Drawing.Size(193, 24);
            this.rtbItemDescription.TabIndex = 12;
            this.rtbItemDescription.Text = "";
            // 
            // tbMaxCapacity
            // 
            this.tbMaxCapacity.Location = new System.Drawing.Point(84, 138);
            this.tbMaxCapacity.Name = "tbMaxCapacity";
            this.tbMaxCapacity.Size = new System.Drawing.Size(193, 24);
            this.tbMaxCapacity.TabIndex = 13;
            this.tbMaxCapacity.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Max Capacity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rtbCharList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtb_console);
            this.Name = "Form1";
            this.Text = "RPG Fighter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_console;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAlliance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox rtbCharList;
        private System.Windows.Forms.Button btItems;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCharName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbItemDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox tbMaxCapacity;
    }
}

