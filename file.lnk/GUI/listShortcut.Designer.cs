namespace lnkFile
{
    partial class listShortcut
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
            this.btnFind = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWorkingDirection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnArguments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFind.Location = new System.Drawing.Point(12, 23);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(95, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find Shortcut";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnDescription,
            this.columnPath,
            this.columnWorkingDirection,
            this.columnArguments});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Location = new System.Drawing.Point(0, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(540, 221);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            this.columnDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDescription.Width = 188;
            // 
            // columnPath
            // 
            this.columnPath.Text = "Path";
            this.columnPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPath.Width = 120;
            // 
            // columnWorkingDirection
            // 
            this.columnWorkingDirection.Text = "Working Direction";
            this.columnWorkingDirection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnWorkingDirection.Width = 154;
            // 
            // columnArguments
            // 
            this.columnArguments.Text = "Arguments";
            this.columnArguments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnArguments.Width = 73;
            // 
            // listShortcut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 284);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnFind);
            this.Name = "listShortcut";
            this.Text = "List Shortcut";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ColumnHeader columnPath;
        private System.Windows.Forms.ColumnHeader columnWorkingDirection;
        private System.Windows.Forms.ColumnHeader columnArguments;
    }
}