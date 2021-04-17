using System.Windows.Forms;

namespace WindowsFormsApp1
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Text = "Form1";

            killProcessBtn = new Button();
            killProcessBtn.Location = new System.Drawing.Point(10, 350);
            killProcessBtn.Size = new System.Drawing.Size(100, 30);
            killProcessBtn.Text = "save";
            killProcessBtn.Click += killProcessClick;

            exitBtn = new Button();
            exitBtn.Location = new System.Drawing.Point(120, 350);
            exitBtn.Size = new System.Drawing.Size(100, 30);
            exitBtn.Text = "exit";
            exitBtn.Click += exitClick;

            startBtn = new Button();
            startBtn.Location = new System.Drawing.Point(230, 350);
            startBtn.Size = new System.Drawing.Size(100, 30);
            startBtn.Text = "start";
            startBtn.Click += startClick;

            processLV = new ListView();
            processLV.Location = new System.Drawing.Point(0, 0);
            processLV.Size = new System.Drawing.Size(800, 330);
            processLV.View = View.List;

            this.Controls.Add(killProcessBtn);
            this.Controls.Add(exitBtn);
            this.Controls.Add(startBtn);
            this.Controls.Add(processLV);
        }


        Button killProcessBtn;
        Button exitBtn;
        Button startBtn;
        ListView processLV;
        #endregion
    }
}