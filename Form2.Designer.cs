namespace CheckListApp_LH
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox; // ✅ Define textBox here

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox(); // ✅ Ensure only here
            this.SuspendLayout();

            // textBox
            this.textBox.Location = new System.Drawing.Point(10, 10);
            this.textBox.Multiline = true;
            this.textBox.Size = new System.Drawing.Size(260, 180);
            this.Controls.Add(this.textBox);

            // Form2
            this.ClientSize = new System.Drawing.Size(280, 200);
            this.Name = "Form2";
            this.Text = "Task Details";
            this.ResumeLayout(false);
        }
    }
}
