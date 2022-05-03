
namespace Random_Calculate
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
            this.Number1Label = new System.Windows.Forms.Label();
            this.OpenadLabel = new System.Windows.Forms.Label();
            this.Number2Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextB_Result = new System.Windows.Forms.TextBox();
            this.TimerCountDown = new System.Windows.Forms.Timer(this.components);
            this.LabelTimeLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Number1Label
            // 
            this.Number1Label.AutoSize = true;
            this.Number1Label.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Number1Label.Location = new System.Drawing.Point(86, 108);
            this.Number1Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Number1Label.Name = "Number1Label";
            this.Number1Label.Size = new System.Drawing.Size(77, 29);
            this.Number1Label.TabIndex = 0;
            this.Number1Label.Text = "Num1";
            // 
            // OpenadLabel
            // 
            this.OpenadLabel.AutoSize = true;
            this.OpenadLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OpenadLabel.Location = new System.Drawing.Point(194, 108);
            this.OpenadLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.OpenadLabel.Name = "OpenadLabel";
            this.OpenadLabel.Size = new System.Drawing.Size(52, 29);
            this.OpenadLabel.TabIndex = 1;
            this.OpenadLabel.Text = "Op.";
            // 
            // Number2Label
            // 
            this.Number2Label.AutoSize = true;
            this.Number2Label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Number2Label.Location = new System.Drawing.Point(275, 108);
            this.Number2Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Number2Label.Name = "Number2Label";
            this.Number2Label.Size = new System.Drawing.Size(77, 29);
            this.Number2Label.TabIndex = 2;
            this.Number2Label.Text = "Num2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // TextB_Result
            // 
            this.TextB_Result.Location = new System.Drawing.Point(425, 108);
            this.TextB_Result.Name = "TextB_Result";
            this.TextB_Result.Size = new System.Drawing.Size(108, 34);
            this.TextB_Result.TabIndex = 5;
            this.TextB_Result.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextB_Result_KeyDown);
            // 
            // TimerCountDown
            // 
            this.TimerCountDown.Enabled = true;
            this.TimerCountDown.Interval = 1000;
            this.TimerCountDown.Tick += new System.EventHandler(this.TimerCountDown_Tick);
            // 
            // LabelTimeLeft
            // 
            this.LabelTimeLeft.AutoSize = true;
            this.LabelTimeLeft.Location = new System.Drawing.Point(146, 59);
            this.LabelTimeLeft.Name = "LabelTimeLeft";
            this.LabelTimeLeft.Size = new System.Drawing.Size(69, 29);
            this.LabelTimeLeft.TabIndex = 6;
            this.LabelTimeLeft.Text = "Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 308);
            this.Controls.Add(this.LabelTimeLeft);
            this.Controls.Add(this.TextB_Result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Number2Label);
            this.Controls.Add(this.OpenadLabel);
            this.Controls.Add(this.Number1Label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Number1Label;
        private System.Windows.Forms.Label OpenadLabel;
        private System.Windows.Forms.Label Number2Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextB_Result;
        private System.Windows.Forms.Timer TimerCountDown;
        private System.Windows.Forms.Label LabelTimeLeft;
    }
}

