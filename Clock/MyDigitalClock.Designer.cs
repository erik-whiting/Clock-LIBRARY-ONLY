namespace Clock
{
    partial class MyDigitalClock
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
            this.SixtySecondTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SixtySecondTimer
            // 
            this.SixtySecondTimer.Interval = 60;
            // 
            // MyDigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 354);
            this.Name = "MyDigitalClock";
            this.Text = "My Digital Clock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer SixtySecondTimer;
    }
}

