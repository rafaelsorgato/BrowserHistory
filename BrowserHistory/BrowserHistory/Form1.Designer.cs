namespace BrowserHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabPage2 = new TabPage();
            firefoxgrid = new DataGridView();
            tabPage1 = new TabPage();
            edgegrid = new DataGridView();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            chromegrid = new DataGridView();
            tabPage4 = new TabPage();
            operagxgrid = new DataGridView();
            groupBox1 = new GroupBox();
            button1 = new Button();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)firefoxgrid).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)edgegrid).BeginInit();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chromegrid).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)operagxgrid).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(firefoxgrid);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1152, 476);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Firefox";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // firefoxgrid
            // 
            firefoxgrid.AllowUserToOrderColumns = true;
            firefoxgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            firefoxgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            firefoxgrid.Dock = DockStyle.Fill;
            firefoxgrid.Location = new Point(3, 3);
            firefoxgrid.Name = "firefoxgrid";
            firefoxgrid.RowHeadersWidth = 51;
            firefoxgrid.RowTemplate.Height = 29;
            firefoxgrid.Size = new Size(1146, 470);
            firefoxgrid.TabIndex = 1;
            firefoxgrid.CellContentClick += firefoxgrid_CellContentClick;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(edgegrid);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1152, 476);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Edge";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // edgegrid
            // 
            edgegrid.AllowUserToOrderColumns = true;
            edgegrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            edgegrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            edgegrid.Dock = DockStyle.Fill;
            edgegrid.Location = new Point(3, 3);
            edgegrid.Name = "edgegrid";
            edgegrid.RowHeadersWidth = 51;
            edgegrid.RowTemplate.Height = 29;
            edgegrid.Size = new Size(1146, 470);
            edgegrid.TabIndex = 0;
            edgegrid.CellContentClick += edgegrid_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1160, 509);
            tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(chromegrid);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1152, 476);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Chrome";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // chromegrid
            // 
            chromegrid.AllowUserToOrderColumns = true;
            chromegrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chromegrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            chromegrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            chromegrid.Location = new Point(0, -2);
            chromegrid.Name = "chromegrid";
            chromegrid.RowHeadersWidth = 51;
            chromegrid.RowTemplate.Height = 29;
            chromegrid.Size = new Size(1152, 480);
            chromegrid.TabIndex = 1;
            chromegrid.CellContentClick += chromegrid_CellContentClick;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(operagxgrid);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1152, 476);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "OperaGX";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // operagxgrid
            // 
            operagxgrid.AllowUserToOrderColumns = true;
            operagxgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            operagxgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            operagxgrid.Dock = DockStyle.Fill;
            operagxgrid.Location = new Point(0, 0);
            operagxgrid.Name = "operagxgrid";
            operagxgrid.RowHeadersWidth = 51;
            operagxgrid.RowTemplate.Height = 29;
            operagxgrid.Size = new Size(1152, 476);
            operagxgrid.TabIndex = 1;
            operagxgrid.CellContentClick += operagxgrid_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(5, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1152, 509);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(470, 225);
            button1.Name = "button1";
            button1.Size = new Size(135, 52);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 509);
            Controls.Add(groupBox1);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "BrowserHistory";
            Load += Form1_Load;
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)firefoxgrid).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)edgegrid).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chromegrid).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)operagxgrid).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabControl tabControl1;
        private DataGridView firefoxgrid;
        private DataGridView edgegrid;
        private TabPage tabPage3;
        private DataGridView chromegrid;
        private TabPage tabPage4;
        private DataGridView operagxgrid;
        private GroupBox groupBox1;
        private Button button1;
    }
}