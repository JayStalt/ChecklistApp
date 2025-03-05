using System;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Drawing;

namespace CheckListApp_LH
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=checklist.db;Version=3;";

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadTasks("Monday"); // Default view Monday
            UpdateStarCount();  // ✅ Show stars when the app starts
            ResetStarCount(); // reset star count

        }

        private void InitializeDatabase()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS tasks (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        day TEXT,
                        time TEXT,
                        description TEXT,
                        completed INTEGER DEFAULT 0,
                        stars INTEGER DEFAULT 0
                    );";

                using (var cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void LoadTasks(string day)
        {
            listBoxTasks.Items.Clear();

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, time, description, completed FROM tasks WHERE day = @day ORDER BY time";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@day", day);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string taskText = $"{reader["time"]} - {reader["description"]}";
                            bool isCompleted = Convert.ToInt32(reader["completed"]) == 1;
                            listBoxTasks.Items.Add(new ChecklistItem(reader.GetInt32(0), taskText, isCompleted));
                        }
                    }
                }
            }
        }

        private void UpdateStarCount()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT SUM(stars) FROM tasks";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    int totalStars = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    lblStarCount.Text = $"⭐ Stars: {totalStars}";
                }
            }
        }

        private void ResetStarCount()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE tasks SET stars = 0"; // Reset all stars
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void ToggleTaskCompleted(int taskId, bool completed)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = completed
                    ? "UPDATE tasks SET completed = @completed, stars = COALESCE(stars, 0) + 1 WHERE id = @id"
                    : "UPDATE tasks SET completed = @completed WHERE id = @id";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@completed", completed ? 1 : 0);
                    cmd.Parameters.AddWithValue("@id", taskId);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadTasks("Monday");
            UpdateStarCount();  // ✅ Update the displayed stars
        }

        private void AddTask(string day, string time, string description)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO tasks (day, time, description, completed) VALUES (@day, @time, @description, 0)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@day", day);
                    cmd.Parameters.AddWithValue("@time", time);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void DeleteTask(int taskId)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM tasks WHERE id = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", taskId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void UpdateTaskTimeAndDescription(int taskId, string newTime, string newDescription)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE tasks SET time = @time, description = @description WHERE id = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@time", newTime);
                    cmd.Parameters.AddWithValue("@description", newDescription);
                    cmd.Parameters.AddWithValue("@id", taskId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string taskDescription = Prompt.ShowDialog("Enter Task Description:", "Add Task", "");
            string taskTime = Prompt.ShowDialog("Enter Task Time (e.g., 2:00 PM):", "Task Time", "");
            if (!string.IsNullOrWhiteSpace(taskDescription) && !string.IsNullOrWhiteSpace(taskTime))
            {
                AddTask("Monday", taskTime, taskDescription);
                LoadTasks("Monday");
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                ChecklistItem selectedTask = (ChecklistItem)listBoxTasks.SelectedItem;
                DeleteTask(selectedTask.Id);
                LoadTasks("Monday");
            }
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                ChecklistItem selectedTask = (ChecklistItem)listBoxTasks.SelectedItem;
                string newTime = Prompt.ShowDialog("Edit Task Time:", "Edit Task", selectedTask.Text.Split('-')[0].Trim());
                string newDescription = Prompt.ShowDialog("Edit Task Description:", "Edit Task", selectedTask.Text.Split('-')[1].Trim());
                if (!string.IsNullOrWhiteSpace(newDescription) && !string.IsNullOrWhiteSpace(newTime))
                {
                    UpdateTaskTimeAndDescription(selectedTask.Id, newTime, newDescription);
                    LoadTasks("Monday");
                }
            }
            else
            {
                MessageBox.Show("Please select a task to edit.", "No Task Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnToggleCompleted_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                ChecklistItem selectedTask = (ChecklistItem)listBoxTasks.SelectedItem;
                ToggleTaskCompleted(selectedTask.Id, !selectedTask.Completed);
            }
        }

        private void cmbDayFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTasks(cmbDayFilter.SelectedItem.ToString());
        }
    }
}