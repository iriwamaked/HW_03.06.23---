namespace HW_03._06._23_DrawButton
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
            SuspendLayout();
            AutoScaleDimensions = new SizeF(6f, 13f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 507);
            Name = nameof(Form1);
            Text = "Рисование кнопками";
            MouseDown += new MouseEventHandler(this.Form1_MouseDown);
            MouseMove += new MouseEventHandler(this.Form1_MouseMove);
            MouseUp += new MouseEventHandler(this.Form1_MouseUp);
            ResumeLayout(false);
        }

        #endregion
    }
}