namespace CheckListApp_LH
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnToggleCompleted;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.ComboBox cmbDayFilter;
        private System.Windows.Forms.Label lblStarCount;

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
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnToggleCompleted = new System.Windows.Forms.Button();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.cmbDayFilter = new System.Windows.Forms.ComboBox();
            this.lblStarCount = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblStarCount (Star Counter Label)
            this.lblStarCount.Location = new System.Drawing.Point(12, 10);
            this.lblStarCount.Size = new System.Drawing.Size(260, 20);
            this.lblStarCount.Text = "⭐ Stars: 0";
            this.lblStarCount.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.lblStarCount);

            // listBoxTasks
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.Location = new System.Drawing.Point(12, 40);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(260, 140);
            this.Controls.Add(this.listBoxTasks);

            // btnAddTask
            this.btnAddTask.Location = new System.Drawing.Point(12, 190);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(120, 30);
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            this.Controls.Add(this.btnAddTask);

            // btnEditTask
            this.btnEditTask.Location = new System.Drawing.Point(152, 190);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(120, 30);
            this.btnEditTask.Text = "Edit Task";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            this.Controls.Add(this.btnEditTask);

            // btnDeleteTask
            this.btnDeleteTask.Location = new System.Drawing.Point(12, 230);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            this.Controls.Add(this.btnDeleteTask);

            // btnToggleCompleted
            this.btnToggleCompleted.Location = new System.Drawing.Point(152, 230);
            this.btnToggleCompleted.Name = "btnToggleCompleted";
            this.btnToggleCompleted.Size = new System.Drawing.Size(120, 30);
            this.btnToggleCompleted.Text = "Toggle Completed";
            this.btnToggleCompleted.UseVisualStyleBackColor = true;
            this.btnToggleCompleted.Click += new System.EventHandler(this.btnToggleCompleted_Click);
            this.Controls.Add(this.btnToggleCompleted);

            // cmbDayFilter
            this.cmbDayFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDayFilter.FormattingEnabled = true;
            this.cmbDayFilter.Items.AddRange(new object[] {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            });
            this.cmbDayFilter.Location = new System.Drawing.Point(12, 270);
            this.cmbDayFilter.Name = "cmbDayFilter";
            this.cmbDayFilter.Size = new System.Drawing.Size(260, 21);
            this.cmbDayFilter.SelectedIndexChanged += new System.EventHandler(this.cmbDayFilter_SelectedIndexChanged);
            this.Controls.Add(this.cmbDayFilter);

            // Form1
            this.ClientSize = new System.Drawing.Size(284, 320);
            this.Name = "Form1";
            this.Text = "Checklist App";
            this.ResumeLayout(false);
        }
    }
}