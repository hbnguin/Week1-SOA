using System.Drawing;
using System.Windows.Forms;

namespace Client_SOA_BN
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
            this.serviceButton1 = new System.Windows.Forms.Button();
            this.serviceButton2 = new System.Windows.Forms.Button();
            this.serviceButton3 = new System.Windows.Forms.Button();
            this.serviceButton4 = new System.Windows.Forms.Button();
            this.serviceButton5 = new System.Windows.Forms.Button();
            this.serviceButton6 = new System.Windows.Forms.Button();
            this.serviceButton7 = new System.Windows.Forms.Button();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.service2TextBox = new System.Windows.Forms.TextBox();
            this.service3TextBox = new System.Windows.Forms.TextBox();
            this.service4TextBox = new System.Windows.Forms.TextBox();
            this.service6TextBox_1 = new System.Windows.Forms.TextBox();
            this.service5TextBox = new System.Windows.Forms.TextBox();
            this.service7TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.service6TextBox_2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceButton1
            // 
            this.serviceButton1.Location = new System.Drawing.Point(147, 58);
            this.serviceButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serviceButton1.Name = "serviceButton1";
            this.serviceButton1.Size = new System.Drawing.Size(140, 50);
            this.serviceButton1.TabIndex = 1;
            this.serviceButton1.Text = "Service 1";
            this.serviceButton1.UseVisualStyleBackColor = true;
            this.serviceButton1.Click += new System.EventHandler(this.serviceButton1_Click);
            // 
            // serviceButton2
            // 
            this.serviceButton2.Location = new System.Drawing.Point(147, 167);
            this.serviceButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serviceButton2.Name = "serviceButton2";
            this.serviceButton2.Size = new System.Drawing.Size(140, 50);
            this.serviceButton2.TabIndex = 2;
            this.serviceButton2.Text = "Service 2";
            this.serviceButton2.UseVisualStyleBackColor = true;
            this.serviceButton2.Click += new System.EventHandler(this.serviceButton2_Click);
            // 
            // serviceButton3
            // 
            this.serviceButton3.Location = new System.Drawing.Point(856, 167);
            this.serviceButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serviceButton3.Name = "serviceButton3";
            this.serviceButton3.Size = new System.Drawing.Size(140, 50);
            this.serviceButton3.TabIndex = 3;
            this.serviceButton3.Text = "Service 3";
            this.serviceButton3.UseVisualStyleBackColor = true;
            this.serviceButton3.Click += new System.EventHandler(this.serviceButton3_Click);
            // 
            // serviceButton4
            // 
            this.serviceButton4.Location = new System.Drawing.Point(481, 167);
            this.serviceButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serviceButton4.Name = "serviceButton4";
            this.serviceButton4.Size = new System.Drawing.Size(140, 50);
            this.serviceButton4.TabIndex = 4;
            this.serviceButton4.Text = "Service 4";
            this.serviceButton4.UseVisualStyleBackColor = true;
            this.serviceButton4.Click += new System.EventHandler(this.serviceButton4_Click);
            // 
            // serviceButton5
            // 
            this.serviceButton5.Location = new System.Drawing.Point(147, 322);
            this.serviceButton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serviceButton5.Name = "serviceButton5";
            this.serviceButton5.Size = new System.Drawing.Size(140, 50);
            this.serviceButton5.TabIndex = 5;
            this.serviceButton5.Text = "Service 5";
            this.serviceButton5.UseVisualStyleBackColor = true;
            this.serviceButton5.Click += new System.EventHandler(this.serviceButton5_Click);
            // 
            // serviceButton6
            // 
            this.serviceButton6.Location = new System.Drawing.Point(481, 322);
            this.serviceButton6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serviceButton6.Name = "serviceButton6";
            this.serviceButton6.Size = new System.Drawing.Size(140, 50);
            this.serviceButton6.TabIndex = 6;
            this.serviceButton6.Text = "Service 6";
            this.serviceButton6.UseVisualStyleBackColor = true;
            this.serviceButton6.Click += new System.EventHandler(this.serviceButton6_Click);
            // 
            // serviceButton7
            // 
            this.serviceButton7.Location = new System.Drawing.Point(856, 322);
            this.serviceButton7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serviceButton7.Name = "serviceButton7";
            this.serviceButton7.Size = new System.Drawing.Size(140, 50);
            this.serviceButton7.TabIndex = 7;
            this.serviceButton7.Text = "Service 7";
            this.serviceButton7.UseVisualStyleBackColor = true;
            this.serviceButton7.Click += new System.EventHandler(this.serviceButton7_Click);
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Location = new System.Drawing.Point(147, 390);
            this.resultDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.RowHeadersWidth = 51;
            this.resultDataGridView.Size = new System.Drawing.Size(991, 375);
            this.resultDataGridView.TabIndex = 8;
            // 
            // service2TextBox
            // 
            this.service2TextBox.Location = new System.Drawing.Point(294, 194);
            this.service2TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.service2TextBox.Name = "service2TextBox";
            this.service2TextBox.Size = new System.Drawing.Size(132, 22);
            this.service2TextBox.TabIndex = 9;
            // 
            // service3TextBox
            // 
            this.service3TextBox.Location = new System.Drawing.Point(294, 350);
            this.service3TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.service3TextBox.Name = "service3TextBox";
            this.service3TextBox.Size = new System.Drawing.Size(132, 22);
            this.service3TextBox.TabIndex = 10;
            // 
            // service4TextBox
            // 
            this.service4TextBox.Location = new System.Drawing.Point(629, 194);
            this.service4TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.service4TextBox.Name = "service4TextBox";
            this.service4TextBox.Size = new System.Drawing.Size(132, 22);
            this.service4TextBox.TabIndex = 11;
            // 
            // service6TextBox_1
            // 
            this.service6TextBox_1.Location = new System.Drawing.Point(631, 348);
            this.service6TextBox_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.service6TextBox_1.Name = "service6TextBox_1";
            this.service6TextBox_1.Size = new System.Drawing.Size(77, 22);
            this.service6TextBox_1.TabIndex = 12;
            // 
            // service5TextBox
            // 
            this.service5TextBox.Location = new System.Drawing.Point(1003, 195);
            this.service5TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.service5TextBox.Name = "service5TextBox";
            this.service5TextBox.Size = new System.Drawing.Size(132, 22);
            this.service5TextBox.TabIndex = 13;
            // 
            // service7TextBox
            // 
            this.service7TextBox.Location = new System.Drawing.Point(1003, 349);
            this.service7TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.service7TextBox.Name = "service7TextBox";
            this.service7TextBox.Size = new System.Drawing.Size(132, 22);
            this.service7TextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Get Country By Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Get Cities By Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Get Cities By Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Get Country By Population";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1006, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Population Of Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1008, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Official Languages ​​Of Countries";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = " ";
            // 
            // service6TextBox_2
            // 
            this.service6TextBox_2.Location = new System.Drawing.Point(721, 348);
            this.service6TextBox_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.service6TextBox_2.Name = "service6TextBox_2";
            this.service6TextBox_2.Size = new System.Drawing.Size(77, 22);
            this.service6TextBox_2.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 802);
            this.Controls.Add(this.service6TextBox_2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.service7TextBox);
            this.Controls.Add(this.service5TextBox);
            this.Controls.Add(this.service6TextBox_1);
            this.Controls.Add(this.service4TextBox);
            this.Controls.Add(this.service3TextBox);
            this.Controls.Add(this.service2TextBox);
            this.Controls.Add(this.resultDataGridView);
            this.Controls.Add(this.serviceButton7);
            this.Controls.Add(this.serviceButton6);
            this.Controls.Add(this.serviceButton5);
            this.Controls.Add(this.serviceButton4);
            this.Controls.Add(this.serviceButton3);
            this.Controls.Add(this.serviceButton2);
            this.Controls.Add(this.serviceButton1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "SOA Services";
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button serviceButton1;
        private System.Windows.Forms.Button serviceButton2;
        private System.Windows.Forms.Button serviceButton3;
        private System.Windows.Forms.Button serviceButton4;
        private System.Windows.Forms.Button serviceButton5;
        private System.Windows.Forms.Button serviceButton6;
        private System.Windows.Forms.Button serviceButton7;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.TextBox service2TextBox;
        private System.Windows.Forms.TextBox service3TextBox;
        private System.Windows.Forms.TextBox service4TextBox;
        private System.Windows.Forms.TextBox service6TextBox_1;
        private System.Windows.Forms.TextBox service5TextBox;
        private System.Windows.Forms.TextBox service7TextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox service6TextBox_2;
    }
}

